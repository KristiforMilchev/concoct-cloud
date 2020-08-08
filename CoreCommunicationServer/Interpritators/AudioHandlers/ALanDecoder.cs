namespace CoreCommunicationServer.Interpritators.AudioHandlers
{
    public class ALanDecoder
    {
        private static byte encode(int pcm)
        {
            //Get the sign bit. Shift it for later use 
            //without further modification
            int sign = (pcm & 0x8000) >> 8;
            //If the number is negative, 
            //make it positive (now it's a magnitude)
            if (sign != 0)
                pcm = -pcm;
            //The magnitude must fit in 15 bits to avoid overflow
            if (pcm > MAX) pcm = MAX;

            /* Finding the "exponent"
            * Bits:
            * 1 2 3 4 5 6 7 8 9 A B C D E F G
            * S 7 6 5 4 3 2 1 0 0 0 0 0 0 0 0
            * We want to find where the first 1 after the sign bit is.
            * We take the corresponding value 
            * from the second row as the exponent value.
            * (i.e. if first 1 at position 7 -> exponent = 2)
            * The exponent is 0 if the 1 is not found in bits 2 through 8.
            * This means the exponent is 0 even if the "first 1" doesn't exist.
            */
            int exponent = 7;
            //Move to the right and decrement exponent 
            //until we hit the 1 or the exponent hits 0
            for (int expMask = 0x4000; (pcm & expMask) == 0 
                && exponent>0; exponent--, expMask >>= 1) { }

            /* The last part - the "mantissa"
            * We need to take the four bits after the 1 we just found.
            * To get it, we shift 0x0f :
            * 1 2 3 4 5 6 7 8 9 A B C D E F G
            * S 0 0 0 0 0 1 . . . . . . . . . (say that exponent is 2)
            * . . . . . . . . . . . . 1 1 1 1
            * We shift it 5 times for an exponent of two, meaning
            * we will shift our four bits (exponent + 3) bits.
            * For convenience, we will actually just
            * shift the number, then AND with 0x0f. 
            * 
            * NOTE: If the exponent is 0:
            * 1 2 3 4 5 6 7 8 9 A B C D E F G
            * S 0 0 0 0 0 0 0 Z Y X W V U T S (we know nothing about bit 9)
            * . . . . . . . . . . . . 1 1 1 1
            * We want to get ZYXW, which means a shift of 4 instead of 3
            */
            int mantissa = (pcm >> ((exponent == 0) ? 4 : (exponent + 3))) & 0x0f;

            //The a-law byte bit arrangement is SEEEMMMM 
            //(Sign, Exponent, and Mantissa.)
            byte alaw = (byte)(sign | exponent << 4 | mantissa);

            //Last is to flip every other bit, and the sign bit (0xD5 = 1101 0101)
            return (byte)(alaw^0xD5);
        }

        private static short decode(byte alaw)
        {
            //Invert every other bit, 
            //and the sign bit (0xD5 = 1101 0101)
            alaw ^= 0xD5;

            //Pull out the value of the sign bit
            int sign = alaw & 0x80;
            //Pull out and shift over the value of the exponent
            int exponent = (alaw & 0x70) >> 4;
            //Pull out the four bits of data
            int data = alaw & 0x0f;

            //Shift the data four bits to the left
            data <<= 4;
            //Add 8 to put the result in the middle 
            //of the range (like adding a half)
            data += 8;
            
            //If the exponent is not 0, then we know the four bits followed a 1,
            //and can thus add this implicit 1 with 0x100.
            if (exponent != 0)
                data += 0x100;
            /* Shift the bits to where they need to be: left (exponent - 1) places
            * Why (exponent - 1) ?
            * 1 2 3 4 5 6 7 8 9 A B C D E F G
            * . 7 6 5 4 3 2 1 . . . . . . . . <-- starting bit (based on exponent)
            * . . . . . . . Z x x x x 1 0 0 0 <-- our data (Z is 0 only when <BR>     * exponent is 0)
            * We need to move the one under the value of the exponent,
            * which means it must move (exponent - 1) times
            * It also means shifting is unnecessary if exponent is 0 or 1.
            */
            if (exponent > 1)
                data <<= (exponent - 1);

            return (short)(sign == 0 ? data : -data);
        }
    }
}