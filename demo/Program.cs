using demo.inheritance;

namespace demo
{
    internal class Program
    {
        #region OverLoad
        public static int Sum(int x, int y) {
        return x + y;
        
        }
        public static int Sum(int x, int y,int z)
        {
            return x + y+z;

        }
        public static double Sum(double x, double y)
        {
            return x + y;

        }
        public static double Sum(int x, double y)
        {
            return x + y;

        }
        public static double Sum(double x, int y)
        {
            return x + y;

        }
        #endregion
        static void Main(string[] args)
        {
            #region Indexer 
            //NoteBook notebook = new NoteBook(3);
            //notebook.AddPerson(0, "abdelrahman", 01041145);
            //notebook.AddPerson(1, "hany", 000000);
            //notebook.AddPerson(2, "ahmed", 01041145);
            //notebook.SetNumbers("hany", 1111111);
            //Console.WriteLine(notebook.GetNumber("hany"));
            //notebook["hany"] = 121212;
            //Console.WriteLine(notebook["hany"]);
            #endregion
            #region Class
            //Car car = new Car(1,150);
            //Console.WriteLine(car);
            #endregion
            #region Inheretance
            //Child child=new Child(3,4,5);
            //Console.WriteLine(child);

            #endregion
            #region Relations Between Classes
            //i implemented the code
            #endregion
            #region Access Modifiers (Private Protected-Protected -Internal Protected)
            //implemented the code
            #endregion

            #region polymarphism 
            #region OverLoading
            Console.WriteLine($"sum equal: {Sum(3,4)}");
            
            #endregion
          
            #endregion


        }
    }
}
