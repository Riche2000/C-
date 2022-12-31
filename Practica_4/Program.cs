using System;

namespace Proyecto
{
    class Program
    {
        static void Main(string[] args)
        { string pregunta1, Resultado_mostrar;
            int preguenta, pregunta3;  
            double vf, vi, tiempo1, altura_1, ace=9.81, resultado_1, resultado, valor_convert;

            double tension1, tension2, velocidad_1, distancia_1;
             
            do
            {   Console.Clear();
                Console.WriteLine("Bienvenidos a una calculadora de fisica");
                Console.WriteLine("1.- Fuerzas en equilibrio ");
                Console.WriteLine("2.- Movimiento Rectilineo Uniforme ");
                Console.WriteLine("3.- Movimiento Uniformemente acelerado ");
                Console.WriteLine("4.- Conversiones");
                Console.WriteLine();
                Console.Write("Escribe tu selección a continuación: ");
                preguenta=Convert.ToInt32(Console.ReadLine());
                string rep= "S";
                    if (preguenta==1){
                        Console.Clear();
                        int aaa=0;
                        Console.WriteLine();
                        Console.WriteLine("Bienvenido a tu practica 1 -  Fuerzas en equilibrio");
                        Console.WriteLine();
                        Console.WriteLine ("En este apartado pordras calular las tensiones de las cuerdas que sostienen a un objeto");
                        Console.WriteLine("a partir de angulos dados, 2 tensiones simultaneas");
                        Console.WriteLine();
                        
                        Console.WriteLine();
                        
                        Console.Write("¿Cuantas veces deseas hacer esta operacion? : ");
                        
                        int add = Convert.ToInt32( Console.ReadLine());
                        Console.WriteLine();
                        Console.Clear();
                        while(aaa < add)
                            { aaa++;
                            Console.Write("Inserta el angulo 1 de la tensión 1: ");
                            double ang1 = Convert.ToDouble(Console.ReadLine());
                            Console.Write ("Inserta el angulo 2 de la tension 2: ");
                            double ang2 = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Ingresa el Masa del objeto en kg: ");
                            double masa1= Convert.ToDouble(Console.ReadLine());
                            double masa= 9.81 * masa1 ;
                            //Console.WriteLine("Masa:" +masa);  -  Funciones de ayuda 
                            //Console.WriteLine("Angulo 1: " + ang1);
                             //Calculo de las tensiones con las formulas desarrolladas
                             //double angulos1 = Math.Cos(ang1* 2.0* Math.PI/360.0);
                             //Console.WriteLine("Angulo Coseno: " + angulos1);
                             tension1=(masa)/(((-Math.Cos(ang1* 2.0* Math.PI/360.0))*Math.Tan(ang2* 2.0* Math.PI/360.0)) + Math.Sin(ang1* 2.0* Math.PI/360.0));
                             tension2= (-tension1 * Math.Cos(ang1* 2.0* Math.PI/360.0))/Math.Cos(ang2* 2.0* Math.PI/360.0);
                             string tensionf2=String.Format("{0:0.000}",tension1);
                             string tensionf1=String.Format("{0:0.000}",tension2);

                            Console.WriteLine();
                            Console.WriteLine("CALCULOS DEL SISTEMA DE FUERZAS " +aaa + ":");
                            Console.WriteLine();
                            Console.WriteLine("Resultado de la tension 1: "+ tensionf1 + "N");
                            Console.WriteLine("Resultado de la tension 2: "+ tensionf2 + "N");
                            Console.WriteLine();

                        }

                        
                       
                        
                    }
                    if(preguenta==2){

                        
                        while( rep=="S")
                        { Console.Clear();
                        Console.WriteLine(" Bienvenidos a la sección de Movimiento Rectilineo Uniforme ");
                        Console.WriteLine();
                        Console.WriteLine("*** Formula a utilizar ***");
                        Console.WriteLine();
                        Console.WriteLine(" d = vt");

                        Console.WriteLine ();
                        Console.WriteLine("1.- Distancia en metros");
                        Console.WriteLine("2.- Velocidad en m/s");
                        Console.WriteLine("3.- tiempo en segundos");
                        Console.WriteLine();
                        Console.Write("Escibre tu elección a continuación: ");
                        pregunta3=Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        Console.Clear();
                        switch(pregunta3){
                            case 1:
                            Console.WriteLine("CALULO DE LA DISTANCIA TOTAL");

                            Console.WriteLine();
                            Console.Write("Inserta la velocidad en m/s: ");
                            velocidad_1 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine();
                            Console.Write("Inserta el tiempo en segundos: ");
                            tiempo1=Convert.ToInt32(Console.ReadLine());
                            distancia_1= velocidad_1 * tiempo1;

                            Resultado_mostrar=String.Format("{0:0.00}",distancia_1);
                            Console.WriteLine("La distancia recorrida es de : " + Resultado_mostrar + " m ");
                            Console.WriteLine();
                                break;
                            case 2: // Calulado de la velocidad
                            Console.WriteLine("CALULO DE LA VELOCIDAD TOTAL");

                            Console.WriteLine();
                            Console.Write("Inserta la distancia recorrida en metros: ");
                            distancia_1 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine();
                            Console.Write("Inserta el tiempo en segundos: ");
                            tiempo1=Convert.ToInt32(Console.ReadLine());
                            velocidad_1= distancia_1 / tiempo1;

                            Resultado_mostrar=String.Format("{0:0.00}",velocidad_1);
                            Console.WriteLine("La velocodad total es de : " + Resultado_mostrar + " m/s ");
                            Console.WriteLine();
                                break;
                            
                            case 3:
                            Console.WriteLine("CALULO DEL TIEMPO TOTAL");

                            Console.WriteLine();
                            Console.Write("Inserta la velocidad en m/s: ");
                            velocidad_1 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine();
                            Console.Write("Inserta la distancia recorrida en metros: ");
                            distancia_1=Convert.ToInt32(Console.ReadLine());
                            tiempo1= velocidad_1 / distancia_1;

                            Resultado_mostrar=String.Format("{0:0.00}",distancia_1);
                            Console.WriteLine();
                            Console.WriteLine("El tiempo total es de : " + Resultado_mostrar + " segundos ");
                            Console.WriteLine();
                                break;
                            
                            default:
                            Console.WriteLine("ESTA OPCIÓN NO EXISTE INTENTALO DE NUEVO");
                                break;



                        }

                        
                        

                        Console.WriteLine();
                        Console.Write(" Deseas realizar otra operación de MRU(S/N): ");
                        rep= Console.ReadLine().ToUpper().Substring(0,1);
                        Console.WriteLine();
                        Console.Clear();
                        }
                        
                    }
                    if(preguenta==3){
                        while( rep=="S"){Console.Clear();

                        
                        Console.WriteLine ();
                        Console.WriteLine ("Bienvenidos a MOVIMIENTO RECTILINEO UNIFORMEMENTE ACELERADO");
                        Console.WriteLine ();
                        Console.WriteLine ("**Formulas a utilizar ***");
                        Console.WriteLine();
                        Console.WriteLine(" Vf   = Vi + at");
                        Console.WriteLine(" X-Xi = Vit + 1/2 at²");
                        Console.WriteLine(" vf²  = Vi² + 2ax");

                        Console.WriteLine();
                        Console.WriteLine("A continuación te presentamos las siguiente opciones para que calules lo que deseas conocer: ");
                        Console.WriteLine();
                        Console.WriteLine("1.- Tiempo de caida al suelo");
                        Console.WriteLine("2.- Velocidad que tendra al caer al suelo");
                        Console.WriteLine("3.- Calcular la posición de un objeto a partir del reposo que es arrojado a una cierta altura" );
                        Console.WriteLine("4.- Calcular la altura de un edicio a partir del tiempo dado");
                        Console.WriteLine();
                        Console.Write("Escribe tu selección a continuación: "); 
                        int pregunta2=Convert.ToInt32(Console.ReadLine());
                        if (pregunta2==1){ 
                            Console.WriteLine(" 1.- CALCULO DE TIEMPO DE CAIDA AL SUELO ");
                            Console.WriteLine();
                            Console.WriteLine("**Formula a utilizar**");
                            Console.WriteLine("t = (vf - vi)/a ");
                            
                            Console.WriteLine();
                            Console.WriteLine("Introduce la velocidad final en m/s: ");
                            vf= Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Introduce la velocidad inicial en m/s:");
                            vi= Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine();

                            tiempo1= (vf- vi) /9.81 ;

                            string tiempo2=String.Format("{0:0.00}",tiempo1);
                            Console.WriteLine("El tiempo de caida es: " + tiempo2 + " s");
                            Console.WriteLine();
                        }
                        if (pregunta2== 2){
                            Console.WriteLine(" 2.- CALCULO VELOCIDAD FINAL (Antes del impacto con el suelo)");
                            Console.WriteLine();
                            Console.WriteLine("**Formula a utilizar**");
                            Console.WriteLine("vf²  = Vi² + 2ax ");
                            
                            Console.WriteLine();
                            Console.WriteLine("Introduce la altura total en metros: ");
                            altura_1= Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Introduce la velocidad inicial en m/s:");
                            vi= Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine();
                            double vi1 = Math.Pow(vi,2);
                            resultado =  vi1 + (2* ace*altura_1);
                            resultado_1= Math.Sqrt(resultado);
                            
                            Resultado_mostrar=String.Format("{0:0.00}",resultado_1);
                            Console.WriteLine("La Velocidad Final de caida es: " + Resultado_mostrar + " m/s");
                            Console.WriteLine();

                        }
                        if (pregunta2==3) //OPCIÓN 3 DE MRUA 
                        {
                            Console.WriteLine(" 3.- Calcular la posición de un objeto a partir del reposo que es arrojado a una cierta altura");
                            Console.WriteLine();
                            Console.WriteLine("**Formula a utilizar**");
                            Console.WriteLine("X-Xi = Vit + 1/2 at²");
                            
                            Console.WriteLine();
                            Console.WriteLine("Introduce el tiempo de caida en segundos: ");
                            tiempo1= Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine();
                            double  tiempo2 = Math.Pow(tiempo1,2);
                            resultado = 0.5 * ace*tiempo2;
                            
                            Resultado_mostrar=String.Format("{0:0.00}",resultado);
                            Console.WriteLine("La Posición del objeto es: " + Resultado_mostrar + " m ");
                            Console.WriteLine();


                        }
                        if ( pregunta2==4) // OPCIÓN 4 DE MRUA 
                        { Console.WriteLine(" 4.- Calcular la altura de un edicio a partir del tiempo dado");
                            Console.WriteLine();
                            Console.WriteLine("**Formula a utilizar**");
                            Console.WriteLine("X-Xi = Vit + 1/2 at²");
                            
                            Console.WriteLine();
                            Console.WriteLine("Introduce el tiempo de caida en segundos: ");
                            tiempo1= Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine();
                            double  tiempo2 = Math.Pow(tiempo1,2);
                            resultado = 0.5 * ace*tiempo2;
                            
                            Resultado_mostrar=String.Format("{0:0.00}",resultado);
                            Console.WriteLine("La Posición del objeto es: " + Resultado_mostrar + " m ");
                            Console.WriteLine();

                        }

                        Console.WriteLine("¿Deseas otra opción de MRUA? (Si/No)");
                        rep=Console.ReadLine().ToUpper().Substring(0,1);
                        }
                    }

                    if (preguenta==4)
                    { while(rep =="S")
                    {   Console.Clear();
                        Console.WriteLine(" BIENVENIDOS A LAS CONVERSIONES");
                        Console.WriteLine();
                        Console.WriteLine("1.- km/h     a  ms/s");
                        Console.WriteLine("2.- m/s      a  km/h");
                        Console.WriteLine("3.- km       a  millas");
                        Console.WriteLine("4.- metros   a  km"); 
                        Console.WriteLine("5.- kg-f     a  Newtons");
                        Console.WriteLine("6.- millas/h a  km/h ");
                        Console.WriteLine("7.- lb       a  kg");

                        Console.WriteLine();
                        Console.WriteLine("Escribe la opción elegida a continuación:");
                        pregunta3= Convert.ToInt32(Console.ReadLine());
                        
                        switch(pregunta3){
                            case 1: // Conversion de km/h a m/s
                                Console.Clear();
                                Console.WriteLine("CONVERSION DE km/h a m/s");
                                Console.WriteLine();
                                Console.WriteLine("Ingresa el valor a convertir: ");
                                valor_convert= Convert.ToDouble(Console.ReadLine());
                                resultado= (valor_convert*1000)/3600;
                                Resultado_mostrar=String.Format("{0:0.00}",resultado);
                                Console.WriteLine();
                                Console.WriteLine("El resultado es: " + Resultado_mostrar + " m/s ");
                                Console.WriteLine();

                                break; 

                            case 2:
                                Console.Clear();
                                Console.WriteLine();
                                Console.WriteLine("CONVERSION DE m/s a km/h");
                                Console.WriteLine();
                                Console.WriteLine("Ingresa el valor a convertir: ");
                                valor_convert= Convert.ToDouble(Console.ReadLine());
                                resultado= (valor_convert*3600)/1000;
                                Resultado_mostrar=String.Format("{0:0.00}",resultado);
                                Console.WriteLine();
                                Console.WriteLine("El resultado es: " + Resultado_mostrar + " km/h ");
                                Console.WriteLine();

                                break;
                            case 3:
                                Console.Clear();
                                Console.WriteLine();
                                Console.WriteLine("CONVERSION DE KM A MILLAS");
                                Console.WriteLine();
                                Console.WriteLine("Ingresa el valor a convertir: ");
                                valor_convert= Convert.ToDouble(Console.ReadLine());
                                resultado= (valor_convert*1)/1.60934;
                                Resultado_mostrar=String.Format("{0:0.000}",resultado);
                                Console.WriteLine();
                                Console.WriteLine("El resultado es: " + Resultado_mostrar + " millas ");
                                Console.WriteLine();
                                break;
                            case 4: //Metros a kilometros
                                Console.Clear();
                                Console.WriteLine();
                                Console.WriteLine("CONVERSION DE METROS A KILOMETROS");
                                Console.WriteLine();
                                Console.WriteLine("Ingresa el valor a convertir: ");
                                valor_convert= Convert.ToDouble(Console.ReadLine());
                                resultado= (valor_convert*1)/1000;
                                Resultado_mostrar=String.Format("{0:0.000}",resultado);
                                Console.WriteLine();
                                Console.WriteLine("El resultado es: " + Resultado_mostrar + " km ");
                                Console.WriteLine();
                                break;
                            case 5: // kilogramos fuerza a Newtons
                                Console.Clear();
                                Console.WriteLine();
                                Console.WriteLine("CONVERSION DE kg-f a Newtons");
                                Console.WriteLine();
                                Console.WriteLine("Ingresa el valor a convertir: ");
                                valor_convert= Convert.ToDouble(Console.ReadLine());
                                resultado= valor_convert*9.80665;
                                Resultado_mostrar=String.Format("{0:0.000}",resultado);
                                Console.WriteLine();
                                Console.WriteLine("El resultado es: " + Resultado_mostrar + " N ");
                                Console.WriteLine();
                                break;

                            case 6: // Millas/h  a km/h
                                Console.Clear();
                                Console.WriteLine();
                                Console.WriteLine("CONVERSION DE millas/h a km/h");
                                Console.WriteLine();
                                Console.WriteLine("Ingresa el valor a convertir: ");
                                valor_convert= Convert.ToDouble(Console.ReadLine());
                                resultado= valor_convert*1.60934;
                                Resultado_mostrar=String.Format("{0:0.000}",resultado);
                                Console.WriteLine();
                                Console.WriteLine("El resultado es: " + Resultado_mostrar + " km/h ");
                                Console.WriteLine();
                                break;

                            case 7: // lb a kilogramos
                                Console.Clear();
                                Console.WriteLine();
                                Console.WriteLine("CONVERSION DE LIBRAS A KILOGRAMOS");
                                Console.WriteLine();
                                Console.WriteLine("Ingresa el valor a convertir: ");
                                valor_convert= Convert.ToDouble(Console.ReadLine());
                                resultado= valor_convert*0.456592;
                                Resultado_mostrar=String.Format("{0:0.000}",resultado);
                                Console.WriteLine();
                                Console.WriteLine("El resultado es: " + Resultado_mostrar + " N ");
                                Console.WriteLine();
                                break;

                            
                            default:
                                Console.Clear();
                                Console.WriteLine();
                                Console.WriteLine("Esa opción no existe intentalo de nuevo");
                                break;

                            




                        }
                        Console.WriteLine();
                        Console.WriteLine("Deseas realizar otra conversiónn: (Si/No)");
                        rep= Console.ReadLine().ToUpper().Substring(0,1);
                    }

                    }
                    if (preguenta != 1 && preguenta != 2 && preguenta != 3 && preguenta != 4 ){
                        Console.WriteLine("Esta opción no existe");
                    }
            // Seccion de decisión si quiere otra opción
                Console.WriteLine();
                Console.Write("¿Deseas otra opción? (Si/No)");
                
                pregunta1=Console.ReadLine().ToUpper().Substring(0,1);
                
            } while(pregunta1=="S");
        }
    }
}