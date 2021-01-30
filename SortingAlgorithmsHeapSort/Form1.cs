using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SortingAlgorithmsHeapSort
{
    public partial class Form1 : Form
    {
        int[] posX;
        int[] lineasX;
        int[] arrFinal;
        int iPosLineasX = 0;
        int posY = 30;
        int iPosX = 0;
        int posXArrOrd;
        double param = 1;
        double velocity = 1;
        public Form1()
        {
            InitializeComponent();
            inicializarPosiciones();
         
        }

        private void inicializarPosiciones()
        {
            int x = GArbol.Bounds.Width / 2 - 10;
            posX = new int[] { x, x - 80, x + 80, x - 128, x - 32, x + 32, x + 128, x - 160, x - 96, x - 48, x - 16, x + 16, x + 48, x + 96, x + 160 };
            lineasX = new int[] { x, x, x - 80, x - 80, x + 80, x + 80, x - 128, x - 128, x - 32, x - 32, x + 32, x + 32, x + 128, x + 128 };
         
        }
        private void HeapMinimo_Click(object sender, EventArgs e)
        {
            try
            {
                string[] temp = ingresoNumeros.Text.Split(',');
               
                if (temp.Length > 15)
                    MessageBox.Show("Max Number of Nodes allowed: 15", "Out of Bounds", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    int[] arr = new int[temp.Length];
                    int[] temp2 = new int[arr.Length + 1];
                    posXArrOrd = (GArbol.Bounds.Width - (GArbol.Bounds.Width - 10));

                    for (int i = 0; i < temp.Length; i++)
                        arr[i] = Convert.ToInt32(temp[i]);

                    for (int i = 0; i < arr.Length; i++)
                        temp2[i + 1] = arr[i];

                    generarHeapMinimo(arr);
                    arrFinal = arr;
                    HeapSort.Enabled = true;
                    HeapMinimo.Enabled = false;
                    button1.Enabled = false;
                  
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Incorrect Input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void graficarArbol(int[] arr, int limite, int index, bool heapSort)
        {
            for (int i = 1; i < limite; i++)
            {
                if (heapSort)
                {
                    if (i == 1)
                        graficarNodoArbol(arr[i], 3);

                    else if (i == limite - 1)
                        graficarNodoArbol(arr[i], 4);

                    else
                        graficarNodoArbol(arr[i], 1);
                    
                    System.Threading.Thread.Sleep(Convert.ToInt32(150/velocity));
                }

                else
                {
                    if (i == index)                                       
                       graficarNodoArbol(arr[i], 2);
                    
                    else                                         
                        graficarNodoArbol(arr[i], 1);
                    
                }

                System.Threading.Thread.Sleep(Convert.ToInt32(150/velocity));
            }

            iPosX = 0;
            iPosLineasX = 0;
            posY = 30;
        }

        private void graficarNodoArbol(int num, int tipo)
        {
            Graphics g = GArbol.CreateGraphics();

            if (iPosX >= 1)//grafico de la linea
            {
                g.DrawLine(new Pen(Color.White, 2), new Point(posX[iPosX] + 15, posY + 3), new Point(lineasX[iPosLineasX] + 15, posY - 41));
                iPosLineasX++;
            }
            if (tipo == 1)//normal
            {

                g.FillEllipse(System.Drawing.Brushes.White, posX[iPosX], posY, 30, 30);

                if (num < -9 || num > 99)
                    g.DrawString("" + num, new Font("Algerian", 10, FontStyle.Bold), System.Drawing.Brushes.Black, new Point(posX[iPosX] + 4, posY + 9));
                else
                    g.DrawString("" + num, new Font("Algerian", 10, FontStyle.Bold), System.Drawing.Brushes.Black, new Point(posX[iPosX] + 10, posY + 9));

            }
            if (tipo == 2)//seleccionado
            {

                g.FillEllipse(System.Drawing.Brushes.Red, posX[iPosX], posY, 30, 30);

                if (num < -9 || num > 99)
                    g.DrawString("" + num, new Font("Algerian", 10, FontStyle.Bold), System.Drawing.Brushes.Black, new Point(posX[iPosX] + 4, posY + 9));
                else
                    g.DrawString("" + num, new Font("Algerian", 10, FontStyle.Bold), System.Drawing.Brushes.Black, new Point(posX[iPosX] + 10, posY + 9));

            }
            if (tipo == 3)//Ordenado
            {

                g.FillEllipse(System.Drawing.Brushes.Green, posX[iPosX], posY, 30, 30);

                if (num < -9 || num > 99)
                    g.DrawString("" + num, new Font("Algerian", 10, FontStyle.Bold), System.Drawing.Brushes.Black, new Point(posX[iPosX] + 4, posY + 9));
                else
                    g.DrawString("" + num, new Font("Algerian", 10, FontStyle.Bold), System.Drawing.Brushes.Black, new Point(posX[iPosX] + 10, posY + 9));

            }
            if (tipo == 4)//eliminado
            {

                g.FillEllipse(System.Drawing.Brushes.Gray, posX[iPosX], posY, 30, 30);

                if (num < -9 || num > 99)
                    g.DrawString("" + num, new Font("Algerian", 10, FontStyle.Bold), System.Drawing.Brushes.Gray, new Point(posX[iPosX] + 4, posY + 9));
                else
                    g.DrawString("" + num, new Font("Algerian", 10, FontStyle.Bold), System.Drawing.Brushes.Gray, new Point(posX[iPosX] + 10, posY + 9));
                iPosLineasX--;
                if(iPosLineasX>= 0)
                g.DrawLine(new Pen(Color.Gray, 2), new Point(posX[iPosX] + 15, posY + 3), new Point(lineasX[iPosLineasX] + 15, posY - 41));
            }

            if (iPosX == 0 || iPosX == 2 || iPosX == 6)
                posY += 70;

            iPosX++;

        }

        private void graficarNodoArrOrdenado(int num)
        {
            Graphics g = GArbol.CreateGraphics();
            g.FillEllipse(System.Drawing.Brushes.Green, posXArrOrd, GArbol.Bounds.Height - 42, 30, 30);

            if (num < -9 || num > 99)
                g.DrawString("" + num, new Font("Algerian", 10), System.Drawing.Brushes.Black, new Point(posXArrOrd + 3, GArbol.Bounds.Height - 38));
            else
                g.DrawString("" + num, new Font("Algerian", 10), System.Drawing.Brushes.Black, new Point(posXArrOrd + 9, GArbol.Bounds.Height - 38));

            posXArrOrd+=30;
        }

        private void generarHeapMinimo(int[] arr)
        {

            int[] temp = new int[arr.Length + 1];// se crea un arreglo temporal para manejar los indices desde 17       
            Graphics g = GArbol.CreateGraphics();
            escribirMinHeap();
            for (int i = 0; i < arr.Length; i++)
                temp[i + 1] = arr[i];


            for (int i = 2; i < temp.Length; i++)//se revisa que la raiz sea menor que los hijos, si no lo es, se hace el cambio
            {
                int padre = i / 2, numTemp;

                if (temp[i] < temp[padre])
                {

                    graficarArbol(temp, i + 1, -1, false);                
                    graficarArbol(temp, i + 1, i, false);
                    //System.Threading.Thread.Sleep(350);

                    numTemp = temp[i];
                    temp[i] = temp[padre];
                    temp[padre] = numTemp;
                    graficarArbol(temp, i + 1, -1, false);

                    i = 1;
                    System.Threading.Thread.Sleep(Convert.ToInt32(300 / velocity));
                }
                else
                    graficarArbol(temp, i + 1, -1, false);
            }

            for (int i = 0; i < arr.Length; i++)//se regresa al arreglo original
                arr[i] = temp[i + 1];
        }

        private void heapSort(int[] arr)
        {
            int longtd = arr.Length;
            int[] arrDesde1;
            for (int i = 0; i < longtd; i++)
            {
                if (arr.Length > 1)
                {
                    int num = arr[0];// se saca la raiz del arbol
                    
                    
                    clearValores();
                    escribirNodoOrdenado(num);

                    int[] temp = new int[arr.Length - 1];
                    temp[0] = arr[arr.Length - 1];
                    
                    for (int j = 1; j < temp.Length; j++)
                        temp[j] = arr[j];


                    arrDesde1 = new int[arr.Length + 1];
                    for (int j = 0; j < arr.Length; j++)
                        arrDesde1[j + 1] = arr[j];

                    graficarArbol(arrDesde1, arrDesde1.Length, -1, true);
                    graficarNodoArrOrdenado(num);
                    System.Threading.Thread.Sleep(Convert.ToInt32(300/velocity));
                    clearValores();
                    escribirNuevaRaiz(temp[0]);
                    
                    arr = temp;
                    insertRaizArbol(arr);
                }

                else
                {
                    arrDesde1 = new int[arr.Length + 1];
                    for (int j = 0; j < arr.Length; j++)
                        arrDesde1[j + 1] = arr[j];

                    clearValores();
                    escribirNodoOrdenado(arr[0]);

                    graficarArbol(arrDesde1, arrDesde1.Length, -1, true);
                    graficarNodoArrOrdenado(arr[0]);
                }

            }
        }

        private void insertRaizArbol(int[] arr)
        {
            int[] temp = new int[arr.Length + 1];// se crea un arreglo temporal para manejar los indices desde 1

            for (int i = 0; i < arr.Length; i++)
                temp[i + 1] = arr[i];

            int raiz = 1, hijoIzq, hijoDer;//se define a la raiz como 1
            bool continuar = true;

            while (continuar)
            {
                hijoIzq = raiz * 2;//se asigna el valor del hijo izq y der
                hijoDer = raiz * 2 + 1;

                int numTemp, hijoMenor;

                if (hijoIzq < temp.Length)//comprueba que exista el hijo izquierdo
                {
                    if (hijoDer >= temp.Length)//si existe el hijo izq, pero el derecho esta fuera del arreglo, entoncs significa que solo tiene un hijo izq
                        hijoMenor = hijoIzq;
                    else
                    {
                        if (temp[hijoIzq] <= temp[hijoDer])//si existen los dos hijos, se busca el menor de los 2 para la comparacion
                            hijoMenor = hijoIzq;
                        else
                            hijoMenor = hijoDer;
                    }

                    if (temp[raiz] > temp[hijoMenor])//si el elemento en la raiz es mayor al hijo menor, se intercambia
                    {
                        clearValores();
                        escribirNodoAIntercambiar(temp[raiz]);
                        
                        graficarArbol(temp, temp.Length, raiz, false);
                        numTemp = temp[raiz];
                        temp[raiz] = temp[hijoMenor];
                        temp[hijoMenor] = numTemp;
                        raiz = hijoMenor;//la nueva raiz para a ser el hijo menor
                        graficarArbol(temp, temp.Length, raiz, false);

                    }

                    else//si la raiz no es mayor a su hijo menor, se termina el push              
                        continuar = false;
                }

                else
                {
                    graficarArbol(temp, temp.Length, -1, false);
                    continuar = false;
                }//si no tiene hijo izq, se termina
            }

            for (int i = 0; i < arr.Length; i++)//se regresa al arreglo original
                arr[i] = temp[i + 1];
        }

        private void HeapSort_Click(object sender, EventArgs e)
        {
            heapSort(arrFinal);
            graficarNodoArbol(1, 4);//elimiar la ultima raiz
            clearValores();
            pantallaFinal();
            HeapSort.Enabled = false;
            button2.Visible = true;
            button3.Visible = true;
            ingresoNumeros.Enabled = false;
            comboBox1.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            
            int limite = rd.Next(5, 15);
            int[] arr = new int[limite];
            string numeros = "";
            for (int i = 0; i < limite; i++)
            {
                int num = rd.Next(-20, 30);
                arr[i] = num;
                if (i == limite - 1)
                    numeros += num;
                else
                    numeros += num + ", ";
            }

            ingresoNumeros.Text = numeros;
        }
        private void escribirNodoOrdenado(int num)
        {
            Graphics g = Valores.CreateGraphics();
            g.DrawString("HEAP OPERATION: ", new Font("Algerian", 16, FontStyle.Bold), System.Drawing.Brushes.Black, new Point(15, 20));
            g.DrawString("DELETE ", new Font("Algerian", 16, FontStyle.Bold), System.Drawing.Brushes.Green, new Point(90, 50));
            g.DrawString("Ordered Node : ", new Font("Algerian", 14, FontStyle.Bold), System.Drawing.Brushes.Gray, new Point(10, 80));
            g.DrawString("(Current root)", new Font("Algerian", 14, FontStyle.Bold), System.Drawing.Brushes.Gray, new Point(10, 100));
            g.DrawString(" " + num, new Font("Algerian", 14, FontStyle.Bold), System.Drawing.Brushes.Green, new Point(190, 90));
            System.Threading.Thread.Sleep(Convert.ToInt32(500 / velocity));
        }
        private void escribirNodoAIntercambiar(int num)
        {
            Graphics g = Valores.CreateGraphics();
            g.DrawString("Heap operation: ", new Font("Algerian", 16, FontStyle.Bold), System.Drawing.Brushes.Black, new Point(15, 20));
            g.DrawString("PUSH ", new Font("Algerian", 16, FontStyle.Bold), System.Drawing.Brushes.Red, new Point(110, 50));
            g.DrawString("The push is made, from up", new Font("Algerian", 14, FontStyle.Bold), System.Drawing.Brushes.Gray, new Point(10, 80));
            g.DrawString("to bottom, of the root: ", new Font("Algerian", 14, FontStyle.Bold), System.Drawing.Brushes.Gray, new Point(10, 100));
            g.DrawString(" " + num, new Font("Algerian", 14, FontStyle.Bold), System.Drawing.Brushes.Red, new Point(260, 100));
            System.Threading.Thread.Sleep(Convert.ToInt32(500 / velocity));

        }
        private void escribirNuevaRaiz(int num)
        {
            Graphics g = Valores.CreateGraphics();
            g.DrawString("HEAP OPERATION: ", new Font("Algerian", 16, FontStyle.Bold), System.Drawing.Brushes.Black, new Point(15, 20));
            g.DrawString("DELETE ", new Font("Algerian", 16, FontStyle.Bold), System.Drawing.Brushes.Green, new Point(90, 50));
            g.DrawString("The new ROOT IS: ", new Font("Algerian", 14, FontStyle.Bold), System.Drawing.Brushes.Gray, new Point(10, 80));
            g.DrawString(" " + num, new Font("Algerian", 14, FontStyle.Bold), System.Drawing.Brushes.Green, new Point(200, 80));
            System.Threading.Thread.Sleep(Convert.ToInt32(500 / velocity));
        }
        private void escribirMinHeap()
        {
            Graphics g = Valores.CreateGraphics();
            g.DrawString("MINIMUN HEAP: ", new Font("Algerian", 14, FontStyle.Bold), System.Drawing.Brushes.Black, new Point(10, 20));
            g.DrawString("an insert of the nodes, one", new Font("Algerian", 12, FontStyle.Bold), System.Drawing.Brushes.Gray, new Point(15, 60));
            g.DrawString("at a time, is made, followed", new Font("Algerian", 12, FontStyle.Bold), System.Drawing.Brushes.Gray, new Point(15, 80));
            g.DrawString("by a push, from bottom to up, ", new Font("Algerian", 12, FontStyle.Bold), System.Drawing.Brushes.Gray, new Point(15, 100));
            g.DrawString("of the inserted node, checking" , new Font("Algerian", 12, FontStyle.Bold), System.Drawing.Brushes.Gray, new Point(15, 120));
            g.DrawString("if its minor than his father", new Font("Algerian", 12, FontStyle.Bold), System.Drawing.Brushes.Gray, new Point(15, 140));

            g.FillEllipse(System.Drawing.Brushes.White, 15,190, 30, 30);
            g.DrawString("Inserted Node", new Font("Algerian", 12, FontStyle.Bold), System.Drawing.Brushes.Gray, new Point(60, 200));

            g.FillEllipse(System.Drawing.Brushes.Red, 15, 240, 30, 30);
            g.DrawString("Node about to exchange", new Font("Algerian", 12, FontStyle.Bold), System.Drawing.Brushes.Gray, new Point(60, 240));
            g.DrawString("with his root", new Font("Algerian", 12, FontStyle.Bold), System.Drawing.Brushes.Gray, new Point(60, 260));
         
        }
        private void pantallaFinal()
        {
            Graphics g = GArbol.CreateGraphics();
            g.DrawString("HEAP", new Font("Algerian", 66, FontStyle.Bold), System.Drawing.Brushes.Black, new Point(GArbol.Bounds.Width/2 -180, 55));
            g.DrawString("SORT", new Font("Algerian", 66, FontStyle.Bold), System.Drawing.Brushes.Black, new Point(GArbol.Bounds.Width / 2 - 60, 140));
            g.DrawString("SORTED ARRAY:", new Font("Algerian", 18, FontStyle.Bold), System.Drawing.Brushes.Black, new Point(15, 260));
         
        }
        private void pantallaInicial()
        {
            Graphics g = GArbol.CreateGraphics();
            g.DrawString("HEAP", new Font("Algerian", 66, FontStyle.Bold), System.Drawing.Brushes.Black, new Point(GArbol.Bounds.Width / 2 - 180, 55));
            g.DrawString("SORT", new Font("Algerian", 66, FontStyle.Bold), System.Drawing.Brushes.Black, new Point(GArbol.Bounds.Width / 2 - 60, 140));
        }
        private void clearValores()
        {
            Graphics g = Valores.CreateGraphics();
            g.Clear(Color.Silver);
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ingresoNumeros.Text = "";
            ingresoNumeros.Enabled = true;
            button1.Enabled = true;
            HeapMinimo.Enabled = true;
            Graphics g = GArbol.CreateGraphics();
            g.Clear(Color.Gray);
            button2.Visible = false;
            button3.Visible = false;
            comboBox1.Enabled = true;
            iPosLineasX = 0;
             posY = 30;
             iPosX = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string vel = (string)comboBox1.SelectedItem;
            velocity = Convert.ToDouble(vel);
          
        }
    }
}
