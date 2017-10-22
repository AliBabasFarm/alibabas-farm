using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Direction_optimized
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }


        List<Edge> map = new List<Edge>();
        List<string> cities = new List<string>();
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadSampleMap();
            KruskalAlgoritm();
            //WritetoListbox();
        }

        private void WritetoListbox()
        {
            
        }

        private void KruskalAlgoritm()
        {
            Edge sample = new Edge();
            List<Edge> Sortedmap = map.OrderBy(o =>o.distance).ToList();
            List<Edge> SelectedEdge = new List<Edge>();
            List<string> InsertedCity = new List<string>();
            double distance = 0;

            for(int i=0;i<Sortedmap.Count;i++)
            {
                if (InsertedCity.IndexOf(Sortedmap[i].p1_name) < 0 || InsertedCity.IndexOf(Sortedmap[i].p2_name) < 0)
                {
                    
                    SelectedEdge.Add(Sortedmap[i]);
                    if(InsertedCity.IndexOf(Sortedmap[i].p1_name) < 0)
                    InsertedCity.Add(Sortedmap[i].p1_name);
                    if (InsertedCity.IndexOf(Sortedmap[i].p2_name) < 0)
                        InsertedCity.Add(Sortedmap[i].p2_name);
                    distance += Sortedmap[i].distance;

                }
                if (InsertedCity.Count == cities.Count)
                    break;
                
            }

            for (int i = 0; i < SelectedEdge.Count; i++)
            { 
                listBox1.Items.Add(SelectedEdge[i].p1_name + SelectedEdge[i].p2_name + " " + SelectedEdge[i].distance);
            }
            label1.Text += distance.ToString();




            


        }

        private void LoadSampleMap()
        {
            cities.Add("A"); cities.Add("B"); cities.Add("C");
            cities.Add("D"); cities.Add("E"); cities.Add("F");
            cities.Add("G"); cities.Add("H"); 
           

            map.Add(new Edge("A", "B", 15));
            map.Add(new Edge("B", "C", 10));
            map.Add(new Edge("C", "H", 20));
            map.Add(new Edge("F", "E",12));
            map.Add(new Edge("A", "D", 20));
            map.Add(new Edge("A", "F", 14));
            map.Add(new Edge("F", "B", 8));
            map.Add(new Edge("B", "E", 13));
            map.Add(new Edge("E", "G", 14));
            map.Add(new Edge("C", "G", 9));
            map.Add(new Edge("G", "H", 15));
            map.Add(new Edge("C", "D", 5));
            map.Add(new Edge("E", "C", 16));
            map.Add(new Edge("E", "H", 25));
            map.Add(new Edge("A", "C", 18));


        }
    }
}
