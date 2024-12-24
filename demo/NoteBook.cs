using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;
using System.Security.Cryptography;

namespace demo
{
    internal struct NoteBook
    {
        #region Attributes
        string[] Names;
        long[] Numbers;
        int size;
        #endregion
        public int Size

        { get { return size; }


        }
        public NoteBook(int _size) {

            size = _size;
            Names = new string[size];
            Numbers = new long[size];
        }
        public void AddPerson(int Position,string Name,long Number) {
            if (Names is not null&&Numbers is not null)
            {
                if (Position>=0&&Position<size)
                {
                    Names[Position] = Name;
                    Numbers[Position] = Number;
                }
           
            }
        
        
        }
        public long GetNumber(string name) {
            if (Names is not null && Numbers is not null) {

                for (int i = 0; i < Names.Length; i++)
                {

                    if (Names[i] == name) return Numbers[i];


                }
               


            }
            return 0;

        }
        public void SetNumbers(string name,long NewNumber) {

            if (Names is not null && Numbers is not null)
            {
                for (int i = 0; i < Names.Length; i++)
                {

                    if (name == Names[i])
                    {
                        Numbers[i] = NewNumber;
                    }


                }
            }


        }
        public long this[string name] {
            get {
                if (Names is not null && Numbers is not null)
                {

                    for (int i = 0; i < Names.Length; i++)
                    {

                        if (Names[i] == name) return Numbers[i];


                    }



                }
                return 0;



            }
            set
            {
                if (Names is not null && Numbers is not null)
                {
                    for (int i = 0; i < Names.Length; i++)
                    {

                        if (name == Names[i])
                        {
                            Numbers[i] = value;
                        }


                    }
                }


            }
        
        
         }

    }
}
