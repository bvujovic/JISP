using JISP.Classes;
using System;
using Xunit;

namespace xUnitTests.Classes
{
    public class LatinicaCirilicaTests
    {
        [Fact]
        public void Cir2Lat_NoChanges()
        {
            var s = "0123456789 ,./<>?;':\"[]\\{}|_";
            Assert.Equal(s, LatinicaCirilica.Cir2Lat(s));
            Assert.Equal(s, LatinicaCirilica.Lat2Cir(s));
        }

        [Fact]
        public void Cir2Lat_Simple()
        {
            var cir = "ШТА";
            var lat = "ŠTA";
            Assert.Equal(lat, LatinicaCirilica.Cir2Lat(cir));
            Assert.Equal(cir, LatinicaCirilica.Lat2Cir(lat));
        }

        [Fact]
        public void Cir2Lat_2letter()
        {
            var cir = "љЉ";
            var lat = "ljLj";
            Assert.Equal(lat, LatinicaCirilica.Cir2Lat(cir));
            Assert.Equal(cir, LatinicaCirilica.Lat2Cir(lat));
        }

        [Fact]
        public void Cir2Lat_SrbLetters()
        {
            var cir = "чћшђжљњЧЋШЂЖЉЊ";
            var lat = "čćšđžljnjČĆŠĐŽLjNj";
            Assert.Equal(lat, LatinicaCirilica.Cir2Lat(cir));
            Assert.Equal(cir, LatinicaCirilica.Lat2Cir(lat));
        }

        [Fact]
        public void Cir2Lat_Me()
        {
            var cir = "Бојан Вујовић";
            var lat = "Bojan Vujović";
            Assert.Equal(lat, LatinicaCirilica.Cir2Lat(cir));
            Assert.Equal(cir, LatinicaCirilica.Lat2Cir(lat));
        }

    }
}
