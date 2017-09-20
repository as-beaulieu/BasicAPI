using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElementAPI.Models;

namespace ElementAPI.Data
{
    public class ElementDataStore
    {
        public static ElementDataStore Current { get; } = new ElementDataStore();
        public List<ElementModel> Elements { get; set; }

        public ElementDataStore()
        {
            Elements = new List<ElementModel>()
            {
                new ElementModel
                {
                    AtomicNumber = 1,
                    Symbol = "H",
                    Name = "Hydrogen",
                    AtomicWeight = 1.007825M,
                    GroupNumber = 1,
                    Family = "Null",
                    Metallic = "Nonmetal",
                    State = "Gas",
                    IsStable = true
                },
                new ElementModel
                {
                    AtomicNumber = 2,
                    Symbol = "He",
                    Name = "Helium",
                    AtomicWeight = 4.00260M,
                    GroupNumber = 18,
                    Family = "Noble Gas",
                    Metallic = "Nonmetal",
                    State = "Gas",
                    IsStable = true
                },
                new ElementModel
                {
                    AtomicNumber = 3,
                    Symbol = "Li",
                    Name = "Lithium",
                    AtomicWeight = 6.941M,
                    GroupNumber = 1,
                    Family = "Alkali Metals",
                    Metallic = "Metal",
                    State = "Solid",
                    IsStable = true
                },
                new ElementModel
                {
                    AtomicNumber = 4,
                    Symbol = "Be",
                    Name = "Beryllium",
                    AtomicWeight = 9.012182M,
                    GroupNumber = 2,
                    Family = "Alkaline Earth Metals",
                    Metallic = "Metal",
                    State = "Solid",
                    IsStable = true
                },
                new ElementModel
                {
                    AtomicNumber = 5,
                    Symbol = "B",
                    Name = "Boron",
                    AtomicWeight = 10.811M,
                    GroupNumber = 13,
                    Family = "Null",
                    Metallic = "Metalloid",
                    State = "Solid",
                    IsStable = true
                },
                new ElementModel
                {
                    AtomicNumber = 6,
                    Symbol = "C",
                    Name = "Carbon",
                    AtomicWeight = 12.0107M,
                    GroupNumber = 14,
                    Family = "Null",
                    Metallic = "Metalloid",
                    State = "Solid",
                    IsStable = true
                },
                new ElementModel
                {
                    AtomicNumber = 7,
                    Symbol = "N",
                    Name = "Nitrogen",
                    AtomicWeight = 14.0067M,
                    GroupNumber = 15,
                    Family = "Null",
                    Metallic = "Nonmetal",
                    State = "Gas",
                    IsStable = true
                },
                new ElementModel
                {
                    AtomicNumber = 8,
                    Symbol = "O",
                    Name = "Oxygen",
                    AtomicWeight = 15.9994M,
                    GroupNumber = 16,
                    Family = "Null",
                    Metallic = "Nonmetal",
                    State = "Gas",
                    IsStable = true
                },
                new ElementModel
                {
                    AtomicNumber = 9,
                    Symbol = "F",
                    Name = "Flourine",
                    AtomicWeight = 18.9984032M,
                    GroupNumber = 17,
                    Family = "Halogens",
                    Metallic = "Nonmetal",
                    State = "Gas",
                    IsStable = true
                },
                new ElementModel
                {
                    AtomicNumber = 10,
                    Symbol = "Ne",
                    Name = "Neon",
                    AtomicWeight = 20.1797M,
                    GroupNumber = 18,
                    Family = "Noble Gasses",
                    Metallic = "Nonmetal",
                    State = "Gas",
                    IsStable = true
                },
                new ElementModel
                {
                    AtomicNumber = 11,
                    Symbol = "Na",
                    Name = "Sodium",
                    AtomicWeight = 22.98976928M,
                    GroupNumber = 1,
                    Family = "Alkali Metals",
                    Metallic = "Metal",
                    State = "Solid",
                    IsStable = true
                },
                new ElementModel
                {
                    AtomicNumber = 12,
                    Symbol = "Mg",
                    Name = "Magnesium",
                    AtomicWeight = 24.3050M,
                    GroupNumber = 2,
                    Family = "Alkaline Earth Metals",
                    Metallic = "Metal",
                    State = "Solid",
                    IsStable = true
                },
                new ElementModel
                {
                    AtomicNumber = 13,
                    Symbol = "Al",
                    Name = "Aluminium",
                    AtomicWeight = 26.9815386M,
                    GroupNumber = 13,
                    Family = "Poor Metals",
                    Metallic = "Metal",
                    State = "Solid",
                    IsStable = true
                },
                new ElementModel
                {
                    AtomicNumber = 14,
                    Symbol = "Si",
                    Name = "Silicon",
                    AtomicWeight = 28.0855M,
                    GroupNumber = 14,
                    Family = "Null",
                    Metallic = "Metalloid",
                    State = "Solid",
                    IsStable = true
                },
                new ElementModel
                {
                    AtomicNumber = 15,
                    Symbol = "P",
                    Name = "Phosphorus",
                    AtomicWeight = 30.973762M,
                    GroupNumber = 15,
                    Family = "Null",
                    Metallic = "Nonmetal",
                    State = "Solid",
                    IsStable = true
                },
                new ElementModel
                {
                    AtomicNumber = 16,
                    Symbol = "S",
                    Name = "Sulphur",
                    AtomicWeight = 32.065M,
                    GroupNumber = 16,
                    Family = "Null",
                    Metallic = "Nonmetal",
                    State = "Solid",
                    IsStable = true
                },
                new ElementModel
                {
                    AtomicNumber = 17,
                    Symbol = "Cl",
                    Name = "Chlorine",
                    AtomicWeight = 35.453M,
                    GroupNumber = 17,
                    Family = "Halogens",
                    Metallic = "Nonmetal",
                    State = "Gas",
                    IsStable = true
                },
                new ElementModel
                {
                    AtomicNumber = 18,
                    Symbol = "Ar",
                    Name = "Argon",
                    AtomicWeight = 39.948M,
                    GroupNumber = 18,
                    Family = "Noble Gasses",
                    Metallic = "Nonmetal",
                    State = "Gas",
                    IsStable = true
                },
                new ElementModel
                {
                    AtomicNumber = 19,
                    Symbol = "K",
                    Name = "Potassium",
                    AtomicWeight = 39.0983M,
                    GroupNumber = 1,
                    Family = "Alkali Metals",
                    Metallic = "Metal",
                    State = "Solid",
                    IsStable = true
                },
                new ElementModel
                {
                    AtomicNumber = 20,
                    Symbol = "Ca",
                    Name = "Calcium",
                    AtomicWeight = 40.078M,
                    GroupNumber = 2,
                    Family = "Alkaline Earth Metals",
                    Metallic = "Metal",
                    State = "Solid",
                    IsStable = true
                },
                new ElementModel
                {
                    AtomicNumber = 21,
                    Symbol = "Sc",
                    Name = "Scandium",
                    AtomicWeight = 44.955912M,
                    GroupNumber = 3,
                    Family = "Transition Metals",
                    Metallic = "Metal",
                    State = "Solid",
                    IsStable = true
                },
                new ElementModel
                {
                    AtomicNumber = 22,
                    Symbol = "Ti",
                    Name = "Titanium",
                    AtomicWeight = 47.867M,
                    GroupNumber = 4,
                    Family = "Transition Metals",
                    Metallic = "Metal",
                    State = "Solid",
                    IsStable = true
                },
                new ElementModel
                {
                    AtomicNumber = 23,
                    Symbol = "V",
                    Name = "Vanadium",
                    AtomicWeight = 50.9415M,
                    GroupNumber = 5,
                    Family = "Transition Metals",
                    Metallic = "Metal",
                    State = "Solid",
                    IsStable = true
                },
                new ElementModel
                {
                    AtomicNumber = 24,
                    Symbol = "Cr",
                    Name = "Chromium",
                    AtomicWeight = 51.9961M,
                    GroupNumber = 6,
                    Family = "Transition Metals",
                    Metallic = "Metal",
                    State = "Solid",
                    IsStable = true
                },
                new ElementModel
                {
                    AtomicNumber = 25,
                    Symbol = "Mn",
                    Name = "Manganese",
                    AtomicWeight = 54.938045M,
                    GroupNumber = 7,
                    Family = "Transition Metals",
                    Metallic = "Metal",
                    State = "Solid",
                    IsStable = true
                },
                new ElementModel
                {
                    AtomicNumber = 26,
                    Symbol = "Fe",
                    Name = "Iron",
                    AtomicWeight = 55.845M,
                    GroupNumber = 8,
                    Family = "Transition Metals",
                    Metallic = "Metal",
                    State = "Solid",
                    IsStable = true
                },
                new ElementModel
                {
                    AtomicNumber = 27,
                    Symbol = "Co",
                    Name = "Cobalt",
                    AtomicWeight = 58.933195M,
                    GroupNumber = 9,
                    Family = "Transition Metals",
                    Metallic = "Metal",
                    State = "Solid",
                    IsStable = true
                },
                new ElementModel
                {
                    AtomicNumber = 28,
                    Symbol = "Ni",
                    Name = "Nickel",
                    AtomicWeight = 68.6934M,
                    GroupNumber = 10,
                    Family = "Transition Metals",
                    Metallic = "Metal",
                    State = "Solid",
                    IsStable = true
                },
                new ElementModel
                {
                    AtomicNumber = 29,
                    Symbol = "Cu",
                    Name = "Copper",
                    AtomicWeight = 63.546M,
                    GroupNumber = 11,
                    Family = "Transition Metals",
                    Metallic = "Metal",
                    State = "Solid",
                    IsStable = true
                },
                new ElementModel
                {
                    AtomicNumber = 30,
                    Symbol = "Zn",
                    Name = "Zinc",
                    AtomicWeight = 65.38M,
                    GroupNumber = 12,
                    Family = "Poor Metals",
                    Metallic = "Metal",
                    State = "Solid",
                    IsStable = true
                },
                new ElementModel
                {
                    AtomicNumber = 31,
                    Symbol = "Ga",
                    Name = "Gallium",
                    AtomicWeight = 69.723M,
                    GroupNumber = 13,
                    Family = "Poor Metals",
                    Metallic = "Metal",
                    State = "Solid",
                    IsStable = true
                },
                new ElementModel
                {
                    AtomicNumber = 32,
                    Symbol = "Ge",
                    Name = "Germanium",
                    AtomicWeight = 72.64M,
                    GroupNumber = 14,
                    Family = "Poor Metals",
                    Metallic = "Metalloid",
                    State = "Solid",
                    IsStable = true
                },
                new ElementModel
                {
                    AtomicNumber = 33,
                    Symbol = "As",
                    Name = "Arsenic",
                    AtomicWeight = 74.92160M,
                    GroupNumber = 15,
                    Family = "Null",
                    Metallic = "Metalloid",
                    State = "Solid",
                    IsStable = true
                },
                new ElementModel
                {
                    AtomicNumber = 34,
                    Symbol = "Se",
                    Name = "Selenium",
                    AtomicWeight = 78.96M,
                    GroupNumber = 16,
                    Family = "Null",
                    Metallic = "Nonmetal",
                    State = "Solid",
                    IsStable = true
                },
                new ElementModel
                {
                    AtomicNumber = 35,
                    Symbol = "Br",
                    Name = "Bromine",
                    AtomicWeight = 79.904M,
                    GroupNumber = 17,
                    Family = "Halogens",
                    Metallic = "Nonmetal",
                    State = "Liquid",
                    IsStable = true
                },
                new ElementModel
                {
                    AtomicNumber = 36,
                    Symbol = "Kr",
                    Name = "Krypton",
                    AtomicWeight = 83.798M,
                    GroupNumber = 18,
                    Family = "Noble Gasses",
                    Metallic = "Nonmetal",
                    State = "Gas",
                    IsStable = true
                },
                new ElementModel
                {
                    AtomicNumber = 37,
                    Symbol = "Rb",
                    Name = "Rubidium",
                    AtomicWeight = 85.4678M,
                    GroupNumber = 1,
                    Family = "Alkali Metals",
                    Metallic = "Metal",
                    State = "Solid",
                    IsStable = true
                },
                new ElementModel
                {
                    AtomicNumber = 38,
                    Symbol = "Sr",
                    Name = "Strontium",
                    AtomicWeight = 87.62M,
                    GroupNumber = 2,
                    Family = "Alkaline Earth Metals",
                    Metallic = "Metal",
                    State = "Solid",
                    IsStable = true
                },
                new ElementModel
                {
                    AtomicNumber = 39,
                    Symbol = "Y",
                    Name = "Yttrium",
                    AtomicWeight = 88.90585M,
                    GroupNumber = 3,
                    Family = "Transition Metals",
                    Metallic = "Metal",
                    State = "Solid",
                    IsStable = true
                },
                new ElementModel
                {
                    AtomicNumber = 40,
                    Symbol = "Zr",
                    Name = "Zirconium",
                    AtomicWeight = 91.224M,
                    GroupNumber = 4,
                    Family = "Transition Metals",
                    Metallic = "Metal",
                    State = "Solid",
                    IsStable = true
                },
                new ElementModel
                {
                    AtomicNumber = 41,
                    Symbol = "Nb",
                    Name = "Niobium",
                    AtomicWeight = 92.90638M,
                    GroupNumber = 5,
                    Family = "Transition Metals",
                    Metallic = "Metal",
                    State = "Solid",
                    IsStable = true
                },
                new ElementModel
                {
                    AtomicNumber = 42,
                    Symbol = "Mo",
                    Name = "Molybdenum",
                    AtomicWeight = 95.96M,
                    GroupNumber = 6,
                    Family = "Transition Metals",
                    Metallic = "Metal",
                    State = "Solid",
                    IsStable = true
                },
                new ElementModel
                {
                    AtomicNumber = 43,
                    Symbol = "Tc",
                    Name = "Technetium",
                    AtomicWeight = 97.9072M,
                    GroupNumber = 7,
                    Family = "Transition Metals",
                    Metallic = "Metal",
                    State = "Solid",
                    IsStable = false
                },
                new ElementModel
                {
                    AtomicNumber = 44,
                    Symbol = "Ru",
                    Name = "Ruthenium",
                    AtomicWeight = 101.07M,
                    GroupNumber = 8,
                    Family = "Transition Metals",
                    Metallic = "Metal",
                    State = "Solid",
                    IsStable = true
                },
                new ElementModel
                {
                    AtomicNumber = 45,
                    Symbol = "Rh",
                    Name = "Rhodium",
                    AtomicWeight = 102.90550M,
                    GroupNumber = 9,
                    Family = "Transition Metals",
                    Metallic = "Metal",
                    State = "Solid",
                    IsStable = true
                },
                new ElementModel
                {
                    AtomicNumber = 46,
                    Symbol = "Pd",
                    Name = "Palladium",
                    AtomicWeight = 106.42M,
                    GroupNumber = 10,
                    Family = "Transition Metals",
                    Metallic = "Metal",
                    State = "Solid",
                    IsStable = true
                },
                new ElementModel
                {
                    AtomicNumber = 47,
                    Symbol = "Ag",
                    Name = "Silver",
                    AtomicWeight = 107.8682M,
                    GroupNumber = 11,
                    Family = "Transition Metals",
                    Metallic = "Metal",
                    State = "Solid",
                    IsStable = true
                },
                new ElementModel
                {
                    AtomicNumber = 48,
                    Symbol = "Cd",
                    Name = "Cadmium",
                    AtomicWeight = 112.411M,
                    GroupNumber = 12,
                    Family = "Null",
                    Metallic = "Metal",
                    State = "Solid",
                    IsStable = true
                },
                new ElementModel
                {
                    AtomicNumber = 49,
                    Symbol = "In",
                    Name = "Indium",
                    AtomicWeight = 114.818M,
                    GroupNumber = 13,
                    Family = "Null",
                    Metallic = "Metal",
                    State = "Solid",
                    IsStable = true
                },
                new ElementModel
                {
                    AtomicNumber = 50,
                    Symbol = "Sn",
                    Name = "Tin",
                    AtomicWeight = 118.710M,
                    GroupNumber = 14,
                    Family = "Null",
                    Metallic = "Metal",
                    State = "Solid",
                    IsStable = true
                },
                new ElementModel
                {
                    AtomicNumber = 51,
                    Symbol = "Sb",
                    Name = "Antimony",
                    AtomicWeight = 121.760M,
                    GroupNumber = 15,
                    Family = "Null",
                    Metallic = "Metalloid",
                    State = "Solid",
                    IsStable = true
                },
                new ElementModel
                {
                    AtomicNumber = 52,
                    Symbol = "Te",
                    Name = "Tellurium",
                    AtomicWeight = 127.60M,
                    GroupNumber = 16,
                    Family = "Null",
                    Metallic = "Nonmetal",
                    State = "Solid",
                    IsStable = true
                },
                new ElementModel
                {
                    AtomicNumber = 53,
                    Symbol = "I",
                    Name = "Iodine",
                    AtomicWeight = 126.90447M,
                    GroupNumber = 17,
                    Family = "Halogens",
                    Metallic = "Nonmetal",
                    State = "Solid",
                    IsStable = true
                },
                new ElementModel
                {
                    AtomicNumber = 54,
                    Symbol = "Xe",
                    Name = "Xeon",
                    AtomicWeight = 131.293M,
                    GroupNumber = 18,
                    Family = "Noble Gasses",
                    Metallic = "Nonmetal",
                    State = "Gas",
                    IsStable = true
                },
                new ElementModel
                {
                    AtomicNumber = 55,
                    Symbol = "Cs",
                    Name = "Caesium",
                    AtomicWeight = 132.9054519M,
                    GroupNumber = 1,
                    Family = "Alkali Metals",
                    Metallic = "Metal",
                    State = "Solid",
                    IsStable = true
                },
                new ElementModel
                {
                    AtomicNumber = 56,
                    Symbol = "Ba",
                    Name = "Barium",
                    AtomicWeight = 137.327M,
                    GroupNumber = 2,
                    Family = "Alkaline Earth Metals",
                    Metallic = "Metal",
                    State = "Solid",
                    IsStable = true
                },
                new ElementModel
                {
                    AtomicNumber = 57,
                    Symbol = "La",
                    Name = "Lanthanum",
                    AtomicWeight = 138.90547M,
                    GroupNumber = 0,
                    Family = "Lanthanoids",
                    Metallic = "Metal",
                    State = "Solid",
                    IsStable = true
                },
                new ElementModel
                {
                    AtomicNumber = 58,
                    Symbol = "Ce",
                    Name = "Cerium",
                    AtomicWeight = 140.116M,
                    GroupNumber = 0,
                    Family = "Lanthanoids",
                    Metallic = "Metal",
                    State = "Solid",
                    IsStable = true
                },
                new ElementModel
                {
                    AtomicNumber = 59,
                    Symbol = "Pr",
                    Name = "Prasedoymium",
                    AtomicWeight = 140.90765M,
                    GroupNumber = 0,
                    Family = "Lanthanoids",
                    Metallic = "Metal",
                    State = "Solid",
                    IsStable = true
                },
                new ElementModel
                {
                    AtomicNumber = 60,
                    Symbol = "Nd",
                    Name = "Neodymium",
                    AtomicWeight = 144.242M,
                    GroupNumber = 0,
                    Family = "Lanthanoids",
                    Metallic = "Metal",
                    State = "Solid",
                    IsStable = true
                },
                new ElementModel
                {
                    AtomicNumber = 61,
                    Symbol = "Pm",
                    Name = "Promethium",
                    AtomicWeight = 145M,
                    GroupNumber = 0,
                    Family = "Lanthanoids",
                    Metallic = "Metal",
                    State = "Solid",
                    IsStable = false
                },
                new ElementModel
                {
                    AtomicNumber = 62,
                    Symbol = "Sm",
                    Name = "Samarium",
                    AtomicWeight = 150.36M,
                    GroupNumber = 0,
                    Family = "Lanthanoids",
                    Metallic = "Metal",
                    State = "Solid",
                    IsStable = true
                },
                new ElementModel
                {
                    AtomicNumber = 63,
                    Symbol = "Eu",
                    Name = "Europium",
                    AtomicWeight = 151.964M,
                    GroupNumber = 0,
                    Family = "Lanthanoids",
                    Metallic = "Metal",
                    State = "Solid",
                    IsStable = true
                },
                new ElementModel
                {
                    AtomicNumber = 64,
                    Symbol = "Gd",
                    Name = "Gadolinium",
                    AtomicWeight = 157.25M,
                    GroupNumber = 0,
                    Family = "Lanthanoids",
                    Metallic = "Metal",
                    State = "Solid",
                    IsStable = true
                },
                new ElementModel
                {
                    AtomicNumber = 65,
                    Symbol = "Tb",
                    Name = "Terbium",
                    AtomicWeight = 158.92535M,
                    GroupNumber = 0,
                    Family = "Lanthanoids",
                    Metallic = "Metal",
                    State = "Solid",
                    IsStable = true
                },
                new ElementModel
                {
                    AtomicNumber = 66,
                    Symbol = "Dy",
                    Name = "Dysprosium",
                    AtomicWeight = 162.500M,
                    GroupNumber = 0,
                    Family = "Lanthanoids",
                    Metallic = "Metal",
                    State = "Solid",
                    IsStable = true
                },
                new ElementModel
                {
                    AtomicNumber = 67,
                    Symbol = "Ho",
                    Name = "Holmium",
                    AtomicWeight = 164.93032M,
                    GroupNumber = 0,
                    Family = "Lanthanoids",
                    Metallic = "Metal",
                    State = "Solid",
                    IsStable = true
                },
                new ElementModel
                {
                    AtomicNumber = 68,
                    Symbol = "Er",
                    Name = "Erbium",
                    AtomicWeight = 167.259M,
                    GroupNumber = 0,
                    Family = "Lanthanoids",
                    Metallic = "Metal",
                    State = "Solid",
                    IsStable = true
                },
                new ElementModel
                {
                    AtomicNumber = 69,
                    Symbol = "Tm",
                    Name = "Thulium",
                    AtomicWeight = 168.93421M,
                    GroupNumber = 0,
                    Family = "Lanthanoids",
                    Metallic = "Metal",
                    State = "Solid",
                    IsStable = true
                },
                new ElementModel
                {
                    AtomicNumber = 70,
                    Symbol = "Yb",
                    Name = "Ytterbium",
                    AtomicWeight = 173.054M,
                    GroupNumber = 0,
                    Family = "Lanthanoids",
                    Metallic = "Metal",
                    State = "Solid",
                    IsStable = true
                },
                new ElementModel
                {
                    AtomicNumber = 71,
                    Symbol = "Lu",
                    Name = "Lutetium",
                    AtomicWeight = 174.9668M,
                    GroupNumber = 0,
                    Family = "Lanthanoids",
                    Metallic = "Metal",
                    State = "Solid",
                    IsStable = true
                },
                new ElementModel
                {
                    AtomicNumber = 72,
                    Symbol = "Hf",
                    Name = "Hafnium",
                    AtomicWeight = 178.49M,
                    GroupNumber = 4,
                    Family = "Transition Metals",
                    Metallic = "Metal",
                    State = "Solid",
                    IsStable = true
                },
                new ElementModel
                {
                    AtomicNumber = 73,
                    Symbol = "Ta",
                    Name = "Tantalum",
                    AtomicWeight = 180.94788M,
                    GroupNumber = 5,
                    Family = "Transition Metals",
                    Metallic = "Metal",
                    State = "Solid",
                    IsStable = true
                },
                new ElementModel
                {
                    AtomicNumber = 74,
                    Symbol = "W",
                    Name = "Tungsten",
                    AtomicWeight = 183.84M,
                    GroupNumber = 6,
                    Family = "Transition Metals",
                    Metallic = "Metal",
                    State = "Solid",
                    IsStable = true
                },
                new ElementModel
                {
                    AtomicNumber = 75,
                    Symbol = "Re",
                    Name = "Rhenium",
                    AtomicWeight = 186.207M,
                    GroupNumber = 7,
                    Family = "Transition Metals",
                    Metallic = "Metal",
                    State = "Solid",
                    IsStable = true
                },
                new ElementModel
                {
                    AtomicNumber = 76,
                    Symbol = "Os",
                    Name = "Osmium",
                    AtomicWeight = 190.23M,
                    GroupNumber = 8,
                    Family = "Transition Metals",
                    Metallic = "Metal",
                    State = "Solid",
                    IsStable = true
                },
                new ElementModel
                {
                    AtomicNumber = 77,
                    Symbol = "Ir",
                    Name = "Iridium",
                    AtomicWeight = 192.217M,
                    GroupNumber = 9,
                    Family = "Transition Metals",
                    Metallic = "Metal",
                    State = "Solid",
                    IsStable = true
                },
                new ElementModel
                {
                    AtomicNumber = 78,
                    Symbol = "Pt",
                    Name = "Platinum",
                    AtomicWeight = 195.084M,
                    GroupNumber = 10,
                    Family = "Transition Metals",
                    Metallic = "Metal",
                    State = "Solid",
                    IsStable = true
                },
                new ElementModel
                {
                    AtomicNumber = 79,
                    Symbol = "Au",
                    Name = "Gold",
                    AtomicWeight = 196.966569M,
                    GroupNumber = 11,
                    Family = "Transition Metals",
                    Metallic = "Metal",
                    State = "Solid",
                    IsStable = true
                },
                new ElementModel
                {
                    AtomicNumber = 80,
                    Symbol = "Hg",
                    Name = "Mercury",
                    AtomicWeight = 200.59M,
                    GroupNumber = 12,
                    Family = "Poor Metals",
                    Metallic = "Metal",
                    State = "Liquid",
                    IsStable = true
                },
                new ElementModel
                {
                    AtomicNumber = 81,
                    Symbol = "Tl",
                    Name = "Thallium",
                    AtomicWeight = 204.3833M,
                    GroupNumber = 13,
                    Family = "Poor Metals",
                    Metallic = "Metal",
                    State = "Solid",
                    IsStable = true
                },
                new ElementModel
                {
                    AtomicNumber = 82,
                    Symbol = "Pb",
                    Name = "Lead",
                    AtomicWeight = 207.2M,
                    GroupNumber = 14,
                    Family = "Poor Metals",
                    Metallic = "Metal",
                    State = "Solid",
                    IsStable = true
                },
                new ElementModel
                {
                    AtomicNumber = 83,
                    Symbol = "Bi",
                    Name = "Bismuth",
                    AtomicWeight = 208.98040M,
                    GroupNumber = 15,
                    Family = "Poor Metals",
                    Metallic = "Metal",
                    State = "Solid",
                    IsStable = true
                },
                new ElementModel
                {
                    AtomicNumber = 84,
                    Symbol = "Po",
                    Name = "Polonium",
                    AtomicWeight = 208.9824M,
                    GroupNumber = 16,
                    Family = "Poor Metals",
                    Metallic = "Metalloid",
                    State = "Solid",
                    IsStable = false
                },
                new ElementModel
                {
                    AtomicNumber = 85,
                    Symbol = "At",
                    Name = "Astatine",
                    AtomicWeight = 209.9871M,
                    GroupNumber = 17,
                    Family = "Poor Metals",
                    Metallic = "Metal",
                    State = "Solid",
                    IsStable = false
                },
                new ElementModel
                {
                    AtomicNumber = 86,
                    Symbol = "Rn",
                    Name = "Radon",
                    AtomicWeight = 222.0176M,
                    GroupNumber = 18,
                    Family = "Noble Gasses",
                    Metallic = "Nonmetal",
                    State = "Gas",
                    IsStable = false
                },
                new ElementModel
                {
                    AtomicNumber = 87,
                    Symbol = "Fr",
                    Name = "Francium",
                    AtomicWeight = 223M,
                    GroupNumber = 1,
                    Family = "Alkali Metals",
                    Metallic = "Metal",
                    State = "Solid",
                    IsStable = false
                },
                new ElementModel
                {
                    AtomicNumber = 88,
                    Symbol = "Ra",
                    Name = "Radium",
                    AtomicWeight = 226M,
                    GroupNumber = 2,
                    Family = "Alkaline Earth Metals",
                    Metallic = "Metal",
                    State = "Solid",
                    IsStable = false
                },
                new ElementModel
                {
                    AtomicNumber = 89,
                    Symbol = "Ac",
                    Name = "Actinium",
                    AtomicWeight = 227M,
                    GroupNumber = 0,
                    Family = "Actinoids",
                    Metallic = "Metal",
                    State = "Solid",
                    IsStable = false
                },
                new ElementModel
                {
                    AtomicNumber = 90,
                    Symbol = "Th",
                    Name = "Thorium",
                    AtomicWeight = 232.03806M,
                    GroupNumber = 0,
                    Family = "Actinoids",
                    Metallic = "Metal",
                    State = "Solid",
                    IsStable = true
                },
                new ElementModel
                {
                    AtomicNumber = 91,
                    Symbol = "Pa",
                    Name = "Protactinium",
                    AtomicWeight = 231.03588M,
                    GroupNumber = 0,
                    Family = "Actinoids",
                    Metallic = "Metal",
                    State = "Solid",
                    IsStable = true
                },
                new ElementModel
                {
                    AtomicNumber = 92,
                    Symbol = "U",
                    Name = "Uranium",
                    AtomicWeight = 238.02891M,
                    GroupNumber = 0,
                    Family = "Actinoids",
                    Metallic = "Metal",
                    State = "Solid",
                    IsStable = true
                },
                new ElementModel
                {
                    AtomicNumber = 93,
                    Symbol = "Np",
                    Name = "Neptunium",
                    AtomicWeight = 237M,
                    GroupNumber = 0,
                    Family = "Actinoids",
                    Metallic = "Metal",
                    State = "Solid",
                    IsStable = false
                },
                new ElementModel
                {
                    AtomicNumber = 94,
                    Symbol = "Pu",
                    Name = "Plutonium",
                    AtomicWeight = 244M,
                    GroupNumber = 0,
                    Family = "Actinoids",
                    Metallic = "Metal",
                    State = "Solid",
                    IsStable = false
                },
                new ElementModel
                {
                    AtomicNumber = 95,
                    Symbol = "Am",
                    Name = "Americium",
                    AtomicWeight = 243M,
                    GroupNumber = 0,
                    Family = "Actinoids",
                    Metallic = "Metal",
                    State = "Solid",
                    IsStable = false
                },
                new ElementModel
                {
                    AtomicNumber = 96,
                    Symbol = "Cm",
                    Name = "Curium",
                    AtomicWeight = 247M,
                    GroupNumber = 0,
                    Family = "Actinoids",
                    Metallic = "Metal",
                    State = "Solid",
                    IsStable = false
                },
                new ElementModel
                {
                    AtomicNumber = 97,
                    Symbol = "Bk",
                    Name = "Berkelium",
                    AtomicWeight = 247M,
                    GroupNumber = 0,
                    Family = "Actinoids",
                    Metallic = "Metal",
                    State = "Solid",
                    IsStable = false
                },
                new ElementModel
                {
                    AtomicNumber = 98,
                    Symbol = "Cf",
                    Name = "Californium",
                    AtomicWeight = 251M,
                    GroupNumber = 0,
                    Family = "Actinoids",
                    Metallic = "Metal",
                    State = "Solid",
                    IsStable = false
                },
                new ElementModel
                {
                    AtomicNumber = 99,
                    Symbol = "Es",
                    Name = "Einsteinium",
                    AtomicWeight = 252M,
                    GroupNumber = 0,
                    Family = "Actinoids",
                    Metallic = "Metal",
                    State = "Solid",
                    IsStable = false
                },
                new ElementModel
                {
                    AtomicNumber = 100,
                    Symbol = "Fm",
                    Name = "Fermium",
                    AtomicWeight = 257M,
                    GroupNumber = 0,
                    Family = "Actinoids",
                    Metallic = "Metal",
                    State = "Solid",
                    IsStable = false
                },
                new ElementModel
                {
                    AtomicNumber = 101,
                    Symbol = "Md",
                    Name = "Mendelevium",
                    AtomicWeight = 258M,
                    GroupNumber = 0,
                    Family = "Actinoids",
                    Metallic = "Metal",
                    State = "Solid",
                    IsStable = false
                },
                new ElementModel
                {
                    AtomicNumber = 102,
                    Symbol = "No",
                    Name = "Nobelium",
                    AtomicWeight = 259M,
                    GroupNumber = 0,
                    Family = "Actinoids",
                    Metallic = "Metal",
                    State = "Solid",
                    IsStable = false
                },
                new ElementModel
                {
                    AtomicNumber = 103,
                    Symbol = "Lr",
                    Name = "Lawrencium",
                    AtomicWeight = 262M,
                    GroupNumber = 0,
                    Family = "Actinoids",
                    Metallic = "Metal",
                    State = "Solid",
                    IsStable = false
                },
                new ElementModel
                {
                    AtomicNumber = 104,
                    Symbol = "Rf",
                    Name = "Rutherfordium",
                    AtomicWeight = 261M,
                    GroupNumber = 4,
                    Family = "Transition Metals",
                    Metallic = "Metal",
                    State = "Unknown",
                    IsStable = false
                },
                new ElementModel
                {
                    AtomicNumber = 105,
                    Symbol = "Db",
                    Name = "Dubnium",
                    AtomicWeight = 262M,
                    GroupNumber = 5,
                    Family = "Transition Metals",
                    Metallic = "Metal",
                    State = "Unknown",
                    IsStable = false
                },
                new ElementModel
                {
                    AtomicNumber = 106,
                    Symbol = "Sg",
                    Name = "Seaborgium",
                    AtomicWeight = 266M,
                    GroupNumber = 6,
                    Family = "Transition Metals",
                    Metallic = "Metal",
                    State = "Unknown",
                    IsStable = false
                },
                new ElementModel
                {
                    AtomicNumber = 107,
                    Symbol = "Bh",
                    Name = "Bohrium",
                    AtomicWeight = 264M,
                    GroupNumber = 7,
                    Family = "Transition Metals",
                    Metallic = "Metal",
                    State = "Unknown",
                    IsStable = false
                },
                new ElementModel
                {
                    AtomicNumber = 108,
                    Symbol = "Hs",
                    Name = "Hassium",
                    AtomicWeight = 277M,
                    GroupNumber = 8,
                    Family = "Transition Metals",
                    Metallic = "Metal",
                    State = "Unknown",
                    IsStable = false
                },
                new ElementModel
                {
                    AtomicNumber = 109,
                    Symbol = "Mt",
                    Name = "Meitnerium",
                    AtomicWeight = 268M,
                    GroupNumber = 9,
                    Family = "Transition Metals",
                    Metallic = "Metal",
                    State = "Unknown",
                    IsStable = false
                },
                new ElementModel
                {
                    AtomicNumber = 110,
                    Symbol = "Ds",
                    Name = "Darmstadtium",
                    AtomicWeight = 271M,
                    GroupNumber = 10,
                    Family = "Transition Metals",
                    Metallic = "Metal",
                    State = "Unknown",
                    IsStable = false
                },
                new ElementModel
                {
                    AtomicNumber = 111,
                    Symbol = "Rg",
                    Name = "Roentgenium",
                    AtomicWeight = 272M,
                    GroupNumber = 11,
                    Family = "Transition Metals",
                    Metallic = "Metal",
                    State = "Unknown",
                    IsStable = false
                },
                new ElementModel
                {
                    AtomicNumber = 112,
                    Symbol = "Uub",
                    Name = "Ununbium",
                    AtomicWeight = 285M,
                    GroupNumber = 12,
                    Family = "Poor Metals",
                    Metallic = "Metal",
                    State = "Unknown",
                    IsStable = false
                },
                new ElementModel
                {
                    AtomicNumber = 113,
                    Symbol = "Uut",
                    Name = "Ununtrium",
                    AtomicWeight = 284M,
                    GroupNumber = 13,
                    Family = "Poor Metals",
                    Metallic = "Metal",
                    State = "Unknown",
                    IsStable = false
                },
                new ElementModel
                {
                    AtomicNumber = 114,
                    Symbol = "Uuq",
                    Name = "Ununquadium",
                    AtomicWeight = 289M,
                    GroupNumber = 14,
                    Family = "Poor Metals",
                    Metallic = "Metal",
                    State = "Unknown",
                    IsStable = false
                },
                new ElementModel
                {
                    AtomicNumber = 115,
                    Symbol = "Uup",
                    Name = "Ununpentium",
                    AtomicWeight = 288M,
                    GroupNumber = 15,
                    Family = "Poor Metals",
                    Metallic = "Metal",
                    State = "Unknown",
                    IsStable = false
                },
                new ElementModel
                {
                    AtomicNumber = 116,
                    Symbol = "Uuh",
                    Name = "Ununhexium",
                    AtomicWeight = 292M,
                    GroupNumber = 16,
                    Family = "Poor Metals",
                    Metallic = "Metal",
                    State = "Unknown",
                    IsStable = false
                },
                new ElementModel
                {
                    AtomicNumber = 117,
                    Symbol = "Uus",
                    Name = "Ununseptium",
                    AtomicWeight = 0M,
                    GroupNumber = 17,
                    Family = "Unknown",
                    Metallic = "Unknown",
                    State = "Unknown",
                    IsStable = false
                },
                new ElementModel
                {
                    AtomicNumber = 118,
                    Symbol = "Uuo",
                    Name = "Ununoctium",
                    AtomicWeight = 294M,
                    GroupNumber = 18,
                    Family = "Noble Gasses",
                    Metallic = "Nonmetal",
                    State = "Unknown",
                    IsStable = false
                },
            };
        }
    }
}
