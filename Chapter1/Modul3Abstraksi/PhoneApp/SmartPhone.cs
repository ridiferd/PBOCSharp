using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneApp
{
    public class SmartPhone : Phone
    {
        public SmartPhone()
        {
        }

        public override string Model { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string Brand { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void Berbunyi()
        {
            Console.WriteLine("Berbunyi");
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override void MelakukanPanggilan()
        {
            Console.WriteLine("Tekan Dialpad pada layar Anda");
        }

        public override void MenerimaPanggilan()
        {
            Console.WriteLine("Tekan tombol hijau atau merah");
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}