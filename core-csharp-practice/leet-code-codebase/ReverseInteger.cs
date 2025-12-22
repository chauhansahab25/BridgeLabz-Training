   
   public class ReverseInteger
{
   public int reverse(int n)
{
     long rev = 0;

        while (n != 0){
            rev = rev * 10 + (n % 10);
            n = n / 10;
        }

        if (rev > int.MaxValue || rev < int.MinValue){   
		return 0;
        }

        return (int)rev;
    }
   
   }