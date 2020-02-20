using System;

namespace Prueba2
{
    class Program{
        static void Main(string[] args){
        }
    }
    class Burbuja {
        private int[] arreglo;
        private int contador;
        private int tamanio; //variable temporal que luego será sustituida por un input 
        Burbuja(){
            contador = 0;
            arreglo = new int[tamanio];
        }
        public void ordenarArreglo(){
            int cont = 0; int pos = 1; int aux;
            for (int i = 0; i < arreglo.Length; i++){
                for (int posi = pos; posi < arreglo.Length; posi++){
                    if (arreglo[cont] > arreglo[pos]){
                        aux = arreglo[pos];
                        cambiarEl(pos, arreglo[cont]);
                        cambiarEl(cont, aux);
                        cont = pos;
                        pos++;
                    }
                    else{
                        pos++;
                        cont++;
                    }
                }
                cont = 0; pos = 1;
            }
            imprimir(0);
        }
        private void cambiarEl(int posi, int valor){
            arreglo[posi]= valor;
        }

        private void imprimir(int pos){
            if (pos < arreglo.Length){
                Console.WriteLine(arreglo[pos] + ", ");
                pos++;
                imprimir(pos);
            }
            else{
                Console.WriteLine("_______");
            }
        }


    }
}
