using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gun.Tasks
{
    class Weapon
    {

        public int bulletCapacity;
        public int bulletCount;
        public int bulletShootSecond;
        public int shootMode;
        public Weapon(int bulletCapacity, int bulletCount, int bulletShootSecond,int shootMode)
        {
            this.bulletCapacity = bulletCapacity;
            this.bulletCount = bulletCount;
            this.bulletShootSecond = bulletShootSecond;
            this.shootMode = shootMode;
        }
        public void Shoot()
        {
            if (bulletCapacity>0 && bulletCount>0)
            {
                if (shootMode==1)
                {
                    bulletCount = bulletCount - 1;
                    Console.WriteLine("Tekli Atesh acildi! Daraqdaki gulle sayi -> " + bulletCount);
                }
                else if (shootMode==2)
                {
                    Console.WriteLine("Daraqdaki butun gulleler atildi ve bu proses " + Fire() + " saniye davam etdi");
                }
               
            }
            else
            {
                Console.WriteLine("atesh achmaq uchun gulle yoxdur.");   
            }

        }
        public int Fire()
        {
            int endShootSecond=0;
            if (bulletCapacity != 0 && bulletCount <= 0)
            {
                endShootSecond = -1;
            }
            else if (bulletCapacity != 0 && bulletCount>0)
            {
                endShootSecond = (bulletCount * bulletShootSecond) / bulletCapacity;
                bulletCount = 0;
            }
            
            return endShootSecond;
        }
       public int GetRemainBulletCount()
        {
            int bulletsNeededCount = 0;
            if (bulletCapacity>=0 && bulletCount >= 0)
            {
                bulletsNeededCount = bulletCapacity - bulletCount;
            }
            
            return bulletsNeededCount;
        }
        public void Reload()
        {
            bulletCount = bulletCapacity;
        }
        public void ChangeFireMode()
        {
            if (shootMode == 1)
            {
                shootMode = 2;
                Console.WriteLine("Atis modu avtomatikdir");
            }
            else if(shootMode == 2)
            {
                shootMode = 1;
                Console.WriteLine("Atis modu teklidir");
            }
        }
    }
}
