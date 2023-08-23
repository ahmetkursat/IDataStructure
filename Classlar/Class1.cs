using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Classlar
{
    public class Class1
    {
        public class OgrenciSistemi
        {
            public OgrenciSistemi(string name, string surName, int no, char subeNo, int sınıfNo, bool cinsiyet)
            {
                Name = name;
                SurName = surName;
                No = no;
                SubeNo = subeNo;
                SınıfNo = sınıfNo;
                Cinsiyet = cinsiyet;
            }

            public string Name { get; set; }
            public string SurName { get; set; }
            public int No { get; set; }
            public char SubeNo { get; set; }
            public int SınıfNo { get; set; }

            public bool Cinsiyet { get; set; }

            public override string ToString()
            {
                return $"{Name} " + $"{SurName} " + $"{SubeNo} " + $"{SınıfNo} " + $"{Cinsiyet} " + $"{No} ";
            }
        }
       
        }


    }

