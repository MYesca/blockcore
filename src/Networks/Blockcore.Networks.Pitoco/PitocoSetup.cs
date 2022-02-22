using System;
using System.Collections.Generic;
using Blockcore.Consensus.Checkpoints;
using Blockcore.Networks.Pitoco.Networks;
using Blockcore.Networks.Pitoco.Networks.Setup;
using NBitcoin;

namespace Blockcore.Networks.Pitoco
{
   internal class PitocoSetup
   {
      internal static PitocoSetup Instance = new PitocoSetup();

      internal CoinSetup Setup = new CoinSetup
      {
         FileNamePrefix = "pitoco",
         ConfigFileName = "pitoco.conf",
         Magic = "01-4D-59-43",
         CoinType = 3601, // SLIP-0044: https://github.com/satoshilabs/slips/blob/master/slip-0044.md,
         PremineReward = 1000000,
         PoWBlockReward = 10,
         PoSBlockReward = 10,
         LastPowBlock = 25000,
         GenesisText = "Times 2021-11-16 How Joe Biden.s Poor Polling Threatens His Major Social Spending Bill", // The New York Times, 2020-04-16
         TargetSpacing = TimeSpan.FromSeconds(64),
         ProofOfStakeTimestampMask = 0x0000000F, // 0x0000003F // 64 sec
         PoSVersion = 3
      };

      internal NetworkSetup Main = new NetworkSetup
      {
         Name = "PitocoMain",
         RootFolderName = "pitoco",
         CoinTicker = "PTC",
         DefaultPort = 15001,
         DefaultRPCPort = 15002,
         DefaultAPIPort = 15003,
         PubKeyAddress = 50, // B https://en.bitcoin.it/wiki/List_of_address_prefixes
         ScriptAddress = 110, // b
         SecretAddress = 160,
         GenesisTime = 1637781809,
         GenesisNonce = 702396,
         GenesisBits = 0x1E0FFFFF,
         GenesisVersion = 1,
         GenesisReward = Money.Zero,
         HashGenesisBlock = "000009400680e17ac2817c03b79091aa887c555028a5c4756172d252fccfdaf0",
         HashMerkleRoot = "0d55e1d467e8cf5c67c0f32e2e4387a12ffd2ad72f5b568e0d5546ac4a263716",
         DNS = new[] { "seed1.mysolution.com.br", "seed2.mysolution.com.br", "ptc.seed.blockcore.net" },
         Nodes = new[] { "20.114.155.241" },
         Checkpoints = new Dictionary<int, CheckpointInfo>
         {
            // TODO: Add checkpoints as the network progresses.
         }
      };

      internal NetworkSetup RegTest = new NetworkSetup
      {
         Name = "PitocoRegTest",
         RootFolderName = "pitocoregtest",
         CoinTicker = "TPTC",
         DefaultPort = 25001,
         DefaultRPCPort = 25002,
         DefaultAPIPort = 25003,
         PubKeyAddress = 111,
         ScriptAddress = 196,
         SecretAddress = 239,
         GenesisTime = 1637781863,
         GenesisNonce = 95568,
         GenesisBits = 0x1F00FFFF,
         GenesisVersion = 1,
         GenesisReward = Money.Zero,
         HashGenesisBlock = "0000462d4a96441271a646b3100cd9ec8551633a253d4f753f8bc1139eb623ca",
         HashMerkleRoot = "26639265c57494a4217ac22fd7d836e88ed09e0c8c8cd9dab92c849e13f9a5ad",
         DNS = new[] { "seedregtest1.ptc.blockcore.net", "seedregtest2.ptc.blockcore.net", "seedregtest.ptc.blockcore.net" },
         Nodes = new[] { "20.114.155.241" },
         Checkpoints = new Dictionary<int, CheckpointInfo>
         {
            // TODO: Add checkpoints as the network progresses.
         }
      };

      internal NetworkSetup Test = new NetworkSetup
      {
         Name = "PitocoTest",
         RootFolderName = "pitocotest",
         CoinTicker = "TPTC",
         DefaultPort = 35001,
         DefaultRPCPort = 35002,
         DefaultAPIPort = 35003,
         PubKeyAddress = 111,
         ScriptAddress = 196,
         SecretAddress = 239,
         GenesisTime = 1637781870,
         GenesisNonce = 6075,
         GenesisBits = 0x1F0FFFFF,
         GenesisVersion = 1,
         GenesisReward = Money.Zero,
         HashGenesisBlock = "000f827c5bf8a3c3ceb2cc686d9eaddcee2a5724e932f9c52a8ac0b77abe6987",
         HashMerkleRoot = "9cecf2c770a1b72006c74d0e5b6adf0c4589ad4ca41bb7d08270635d9a83e0e9",
         DNS = new[] { "seedtest1.ptc.blockcore.net", "seedtest2.ptc.blockcore.net", "seedtest.ptc.blockcore.net" },
         Nodes = new[] { "20.114.155.241" },
         Checkpoints = new Dictionary<int, CheckpointInfo>
         {
            // TODO: Add checkpoints as the network progresses.
         }
      };

      public bool IsPoSv3()
      {
         return Setup.PoSVersion == 3;
      }

      public bool IsPoSv4()
      {
         return Setup.PoSVersion == 4;
      }
   }
}
