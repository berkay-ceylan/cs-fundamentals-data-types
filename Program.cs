namespace _03_degiskenler2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //C# Programlama dilindeki veri tipleri

            #region Tamsayılar


            // Byte - 8 bit

            Console.WriteLine(nameof(Byte));
            Console.WriteLine($"Alt limit:\t{byte.MinValue}");
            Console.WriteLine($"Üst limit:\t{byte.MaxValue}");
            Console.WriteLine($"boyut:\t{sizeof(Byte)}");

            Console.WriteLine(new string('*', 50));


            //SByte 8 - bit

            Console.WriteLine(nameof(SByte));
            Console.WriteLine($"Alt limit:\t{sbyte.MinValue}");
            Console.WriteLine($"Üst limit:\t{sbyte.MaxValue}");
            Console.WriteLine($"boyut:\t{sizeof(SByte)}");

            Console.WriteLine(new string('*', 50));


            //Short(Int16) 16-bit

            Console.WriteLine(nameof(Int16));
            Console.WriteLine($"Alt limit:\t{short.MinValue}");
            Console.WriteLine($"Üst limit:\t{short.MaxValue}");
            Console.WriteLine($"boyut:\t{sizeof(Int16)}");

            Console.WriteLine(new string('*', 50));


            // UShort(UInt16) - 16 bit

            Console.WriteLine(nameof(UInt16));
            Console.WriteLine($"Alt limit:\t{ushort.MinValue}");
            Console.WriteLine($"Üst limit:\t{ushort.MaxValue}");
            Console.WriteLine($"boyut:\t{sizeof(UInt16)}");

            Console.WriteLine(new string ('*',50));


            // Int(Int32) - 32 bit

            Console.WriteLine(nameof(Int32));
            Console.WriteLine($"Alt limit:\t{Int32.MinValue}");
            Console.WriteLine($"Üst limit:\t{Int32.MaxValue}");
            Console.WriteLine($"boyut:\t{sizeof(Int32)}");

            Console.WriteLine(new string('*', 50));


            // UInt(UInt32) - 32 bit

            Console.WriteLine(nameof(UInt32));
            Console.WriteLine($"Alt limit:\t{UInt32.MinValue}");
            Console.WriteLine($"Üst limit:\t{UInt32.MaxValue}");
            Console.WriteLine($"boyut:\t{sizeof(UInt32)}");

            Console.WriteLine(new string('*', 50));


            // long(Int64) - 64 bit

            Console.WriteLine(nameof(Int64));
            Console.WriteLine($"Alt limit:\t{Int64.MinValue}");
            Console.WriteLine($"Üst limit:\t{Int64.MaxValue}");
            Console.WriteLine($"boyut:\t{sizeof(Int64)}");

            Console.WriteLine(new string('*', 50));


            //Ulong(UInt64) - 64 bit

            Console.WriteLine(nameof(UInt64));
            Console.WriteLine($"Alt limit:\t{UInt64.MinValue}");
            Console.WriteLine($"Üst limit:\t{UInt64.MaxValue}");
            Console.WriteLine($"boyut:\t{sizeof(UInt64)}");

            Console.WriteLine(new string('*', 50));


            #endregion


            #region OndalıklıSayılar


            float sayi1 = 12.3f;
            double sayi2 = 12.3d;
            decimal sayi3 = 12.2m;

            
            //float (Single-32 Bit) .dan sonra 7 anlamlı hane gelir. 

            Console.WriteLine(nameof(Single));
            Console.WriteLine($"Alt limit:\t{float.MinValue}");
            Console.WriteLine($"Üst limit:\t{float.MaxValue}");
            Console.WriteLine($"boyut:\t{sizeof(float)}");

            Console.WriteLine(new string('*', 50));


            //Double (64 Bit) .dan sonra 15-16 anlamlı hane gelir.

            Console.WriteLine(nameof(Double));
            Console.WriteLine($"Alt limit:\t{double.MinValue}");
            Console.WriteLine($"Üst limit:\t{double.MaxValue}");
            Console.WriteLine($"boyut:\t{sizeof(double)}");

            Console.WriteLine(new string('*', 50));


            //Decimal (128 Bit) .dan sonra 29 anlamlı hane gelir.

            Console.WriteLine(nameof(Decimal));
            Console.WriteLine($"Alt limit:\t{Decimal.MinValue}");
            Console.WriteLine($"Üst limit:\t{Decimal.MaxValue}");
            Console.WriteLine($"boyut:\t{sizeof(Decimal)}");

            Console.WriteLine(new string('*', 50));


            #endregion


            #region Karakterler


            //Char 

            Console.WriteLine(nameof(Char));
            Console.WriteLine($"Alt limit:\t{Char.MinValue}");
            Console.WriteLine($"Üst limit:\t{Char.MaxValue}");
            Console.WriteLine($"boyut:\t{sizeof(Char)}");

            Console.WriteLine(new string('*', 50));


            //String aslında bir char dizisidir. Bir alt ve üst limiti yoktur




            #endregion


            #region Boolean

            // Boolean (8 Bit) false(0) ya da true(1) döner
            Console.WriteLine(nameof(Boolean));
            Console.WriteLine($"Boyut:\t{sizeof(Boolean)}");

            #endregion


            #region Object

            // // Object C#'taki tüm türlerin atasıdır. değer tipinin object e  atanmasına boxing denir, kutudan geri almak için orijinal türe açık dönüştürme (unboxing) gerekir. string bir referans tiptir, bu yüzden object'e atanırken boxing olmaz. object -> string dönüşümü unboxing değil, referans cast'idir.
            Console.WriteLine(nameof(Object));
            object obj1 = 42;
            object obj2 = 43.3;
            object obj3 = "merhaba";
            object obj4 = true;


            #endregion


            #region Var

            // var, yerel değişkenlerde atanan ilk değerden türü derleme zamanında çıkarır (dynamic değildir) ve değişkenin mutlaka başlangıç değeri almasını zorunlu kılar.
            
            var var1 = 10;
            var var2 = 20.5;
            var var3 = "merhaba";
            var var4 = true;


            #endregion


            #region  Dynamic

            // dynamic tür ve üye denetimini çalışma zamanına bırakan (derleme zamanı kontrolü yapmayan) esnek bir türdür bu yüzden her atamada tür değişebilir ve hataları derlemede değil çalışırken alırız.

            dynamic degisken1 = 10;
            dynamic degisken2 = "metin";
            
            #endregion
        }
    }
}
