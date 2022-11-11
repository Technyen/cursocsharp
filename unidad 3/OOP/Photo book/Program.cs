using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class PhotoBookTest
    {
        static void Main(string[] args)
        {
            Photobook myPhotoB = new Photobook();

            Photobook myPhotoB2= new Photobook(24);
            BigPhotoBook myBigB = new BigPhotoBook();
            
            myPhotoB.ShowNumber();
            myPhotoB.GetNumberPages();
           
            myPhotoB2.ShowNumber();
            myBigB.ShowNumber();
          
        }

        public class Photobook
        {
            protected int numPages;
            public Photobook()
            {
                numPages = 16;
            }

            public Photobook (int numPages2)
            {
                numPages = numPages2;
            }

            public int GetNumberPages()
            {
                return numPages;
            }

            public void ShowNumber()
            {
                Console.WriteLine("numPages is " + numPages);
                            
            }
        }


        public class BigPhotoBook:Photobook
        {
         
            public BigPhotoBook()
            {
                numPages = 64; 
            }
        }





















    }

}