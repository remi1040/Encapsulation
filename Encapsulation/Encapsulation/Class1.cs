using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class BeerEncapsulator
    {
        private float _avalaibleBeerVolume;
        private int _avalaibleBottles;
        private int _avalaibleCapsules;

        public BeerEncapsulator(float volumeBeer, int nombreBouteilles, int nombreCapsule) 
        {
            this._avalaibleBeerVolume = volumeBeer;
            this._avalaibleBottles = nombreBouteilles;
            this._avalaibleCapsules = nombreCapsule;
        }

        public void AddBeer(float ajoutBiere)
        {
            this._avalaibleBeerVolume += ajoutBiere;
        }

        public int ProduceEncapsulatedBeerBottles(int nombreBouteilles)
        {
            if (nombreBouteilles <= this._avalaibleBottles && nombreBouteilles <= this._avalaibleCapsules && nombreBouteilles*0.33 <= this._avalaibleBeerVolume) 
            {
                int nombreBouteillesRempli = 0;

                for ( int i = 0; i < nombreBouteilles; i++)
                {
                    if (_avalaibleBeerVolume > 0.33)
                    {
                        this._avalaibleBottles -= 1;
                        this._avalaibleCapsules -= 1;
                        this._avalaibleBeerVolume -= 0.33f;
                        nombreBouteillesRempli += 1;
                    }
                }
                return nombreBouteillesRempli;
            }
            else
            {
                if (nombreBouteilles > this._avalaibleBottles)
                {
                    Console.WriteLine($"Il va manquer {nombreBouteilles - this._avalaibleBottles} bouteilles ! ");
                }
                if (nombreBouteilles > this._avalaibleCapsules)
                {
                    Console.WriteLine($"Il va manquer {nombreBouteilles - this._avalaibleCapsules} capsule ! ");
                }
                if (nombreBouteilles * 0.33 > this._avalaibleBeerVolume)
                {
                    Console.WriteLine($"Il va manquer {this._avalaibleBeerVolume - nombreBouteilles * 0.33 } cl de bieres ! ");
                }
                return 0;
            }
        }

    }
}
