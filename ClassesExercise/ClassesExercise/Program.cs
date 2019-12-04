using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesExercise
{
    class Television
    {
        private int currentChannel;
        private int currentVolume;

        public void increaseVolume()
        {
            currentVolume++;
        }
        public void decreaseVolume()
        {
            currentVolume--;
        }
        public int volume()
        {
            return currentVolume;

        }
        public void increaseChannel()
        {
            currentChannel++;
        }
        public void decreaseChannel()
        {
            currentChannel--;
        }
        public int channel()
        {
            return currentChannel;
        }
    };

    class DigitalPiggyBank
    {
        private float currentBalance;

        public void deposit(float net)
        {
            currentBalance += net;
        }

        public float withdraw()
        {
            float tmp = currentBalance;
            currentBalance = 0;
            return tmp;
        }

        public float balance()
        {
            return currentBalance;
        }
    };

    struct ServerInfo
    {
        public int regionID;
        public int currentPlayerCount;
        public int maxPlayers;
        public int ping;
    }

    class ServerBrowserService
    {
        private ServerInfo[] servers = new ServerInfo[50];

        private int serverCount;

        public bool registerServer(ServerInfo newServer)
        {
            if (serverCount > 50) { 
            return false;
            }

            servers [serverCount] = newServer;
            serverCount++;
            return true;
        }

        public int getServers(ref ServerInfo[] dstArray, int pingLimit)
        {
            dstArray = new ServerInfo[50];
            int svrsCopied2 = 0;
            int dstIndex = 0;

            for (svrsCopied2 = 0; svrsCopied2 < serverCount; svrsCopied2++)
            {
                if (servers[svrsCopied2].ping < pingLimit)
                {
                    dstArray[svrsCopied2] = servers[svrsCopied2];
                    dstIndex++;
                }
            }
            return svrsCopied2;
        }
    };
}
