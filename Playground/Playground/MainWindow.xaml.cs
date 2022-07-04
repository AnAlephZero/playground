using Playground.Algos;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Playground
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            FiboBase f = new FiboBase();
            int fibo = f.Fibo(7);
            Debug.WriteLine("Fibo of 6 is: ", fibo);

            FiboMemo fm = new FiboMemo();
            int fiboFm = fm.Fibo(7);
            Debug.WriteLine("Fibo of 6 is: ", fiboFm);

            MatrixPath path = new MatrixPath();
            int pathNo = path.getPathNumber(0, 0);
            Debug.WriteLine("Fibo of 6 is: ", pathNo);

            MatrixPathMemo pathMemo = new MatrixPathMemo();
            int pathNoMemo = pathMemo.getPathNumber(0, 0);
            Debug.WriteLine("Fibo of 6 is: ", pathNoMemo);


            GraphDSF g = new GraphDSF(4);

            g.AddEdge(0, 1);
            g.AddEdge(0, 2);
            g.AddEdge(1, 2);
            g.AddEdge(2, 0);
            g.AddEdge(2, 3);
            g.AddEdge(3, 3);

            Debug.WriteLine(
                "Following is Depth First Traversal "
                + "(starting from vertex 2)");

            g.DFS(0);
            //Console.ReadKey();


            BinarySearch binarySearch = new BinarySearch();
            int[] array = new int[] { 3, 4, 5, 6, 7, 8, 9};
            int n = array.Length;
            int x = 4;
            Boolean resultRec = binarySearch.searchRecursive(array, x, 0, n - 1);

            Boolean resultIte = binarySearch.searchIterative(array, x);

            int a = 0;
        }
    }
}
