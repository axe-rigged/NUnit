namespace Merkkijono
{
    public class Merkkit
    {
        public Merkkit()
        {


        }

        public int laske(string x)
        {

            if (x.Length == 0)
            {
                return 0;
            }

            char[] rikkoja = new char[] { ',', '\n' };
            string[] numbs = x.Split(rikkoja);

            int sum = 0;

            foreach (string yksnumero in numbs)
            {
                sum += int.Parse(yksnumero);
            }
           
            return sum;
            
        }
    }

}