using MagicVilla_VillaApi.Model.Dto;

namespace MagicVilla_VillaApi.Data
{
    public static class VillaStore
    {
        public static List<VillaDTO> villaList = new List<VillaDTO> {
            new VillaDTO {Id=1, Name="Poolii View",Sqft=100,Occupancy=4},
            new VillaDTO {Id=2, Name="Beachii View",Sqft=300,Occupancy=3}
        };
    }
}
