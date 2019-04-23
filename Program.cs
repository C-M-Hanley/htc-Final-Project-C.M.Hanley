using System;

public class Program
{
	public static void Main()
	{
		while (true)
		{
			Console.WriteLine();
			Console.WriteLine("Hello this is a taxonomy classification key. You can classify any of these specimens: elephant, beetle, snake, butterfly, stingray, chipmunk, salamander, wasp, shrew, zebra, grapes, hare, American flag, swan, spider, lion, fish, mushroom, toad, grasshopper, deer, gibbon, fly, or a bacterium.");
			Console.WriteLine("1- Microscopic or 2- Macroscopic");
			string micro = Console.ReadLine();
			if (micro == "1")
			{
				Console.WriteLine("Your speciman is a bacterium in the kingdom: Monera.");
			}
            else if (micro == "bacterium")
            {
               Console.WriteLine("Your speciman is a bacterium in the kingdom: Monera."); 
            }
            else if (micro == "elephant")
            {
               Console.WriteLine("Your speciman is an elephant. Kingdom: Animalia, Phylum: Chordata, Class: Mammalia, Order: Proboscidea"); 
            }
            else if (micro == "beetle")
            {
               Console.WriteLine("Your speciman is a beetle. Kingdom: Animalia, Phylum: Arthropoda, Class: Insecta, Order: Coleoptera"); 
            }
            else if (micro == "snake")
            {
               Console.WriteLine("Your speciman is a snake. Kingdom: Animalia, Phylum: Chordata, Class: Reptilia"); 
            }
            else if (micro == "butterfly")
            {
               Console.WriteLine("Your speciman is a butterfly. Kingdom: Animalia, Phylum: Arthropoda, Class: Insecta, Order: Lepidoptera"); 
            }
            else if (micro == "stingray")
            {
               Console.WriteLine("Your speciman is a stingray. Kingdom: Animalia, Phylum: Chordata, Class: Chondrichthes"); 
            }
            else if (micro == "chipmunk")
            {
               Console.WriteLine("Your speciman is a chipmunk. Kingdom: Animalia, Phylum: Chordata, Class: Mammalia, Order: Rodentia"); 
            }
            else if (micro == "salamander")
            {
               Console.WriteLine("Your speciman is a salamander. Kingdom: Animalia, Phylum: Chordata, Class: Amphibia, Order: Caudata"); 
            }
             else if (micro == "wasp")
            {
               Console.WriteLine("Your speciman is a wasp. Kingdom: Animalia, Phylum: Arthropoda, Class: Insecta, Order: hymenoptera"); 
            }
            else if (micro == "shrew")
            {
               Console.WriteLine("Your speciman is a shrew. Kingdom: Animalia, Phylum: Chordata, Class: Mammalia, Order: Insectivora"); 
            }
            else if (micro == "zebra")
            {
               Console.WriteLine("Your speciman is a zebra. Kingdom: Animalia, Phylum: Chordata, Class: Mammalia, Order: Perissodactyla"); 
            }
            else if (micro == "grapes")
            {
               Console.WriteLine("Your speciman is a grape. Kingdom: Plantae, Phylum: Anthophyta, Class: Diccotyledoneae."); 
            }
            else if (micro == "hare")
            {
               Console.WriteLine("Your speciman is a hare. Kingdom: Animalia, Phylum: Chordata, Class: Mammalia, Order: Lagomorpha"); 
            }
            else if (micro == "Amerian flag")
            {
               Console.WriteLine("Your speciman is an American Flag. Kingdom: Plantae, Phylum: Anthophyta, Class: Monocotyledoneae."); 
            }
            else if (micro == "swan")
            {
               Console.WriteLine("Your speciman is a swan. Kingdom: Animalia, Phylum: Chordata, Class: Aves"); 
            }
            else if (micro == "spider")
            {
               Console.WriteLine("Your speciman is a spider. Kingdom: Animalia, Phylum: Arthropoda, Class: Arachnida"); 
            }
            else if (micro == "lion")
            {
               Console.WriteLine("Your speciman is a lion. Kingdom: Animalia, Phylum: Chordata, Class: Mammalia, Order: Carnivora"); 
            }
            else if (micro == "fish")
            {
               Console.WriteLine("Your speciman is a fish. Kingdom: Animalia, Phylum: Chordata, Class: Osteichthyes"); 
            }
            else if (micro == "mushroom")
            {
               Console.WriteLine("Your speciman is a mushroom in the Kingdom: Fungi"); 
            }
            else if (micro == "toad")
            {
               Console.WriteLine("Your speciman is a toad. Kingdom: Animalia, Phylum: Chordata, Class: Amphibia, Order: Anura"); 
            }
             else if (micro == "grasshopper")
            {
               Console.WriteLine("Your speciman is a grashopper. Kingdom: Animalia, Phylum: Arthropoda, Class: Insecta, Order: Orthoptera"); 
            }
            else if (micro == "deer")
            {
               Console.WriteLine("Your speciman is a deer. Kingdom: Animalia, Phylum: Chordata, Class: Mammalia, Order: Artiodactyla"); 
            }
             else if (micro == "gibbon")
            {
               Console.WriteLine("Your speciman is a gibbon. Kingdom: Animalia, Phylum: Chordata, Class: Mammalia, Order: Primates"); 
            }
            else if (micro == "fly")
            {
               Console.WriteLine("Your speciman is a fly. Kingdom: Animalia, Phylum: Arthropoda, Class: Insecta, Order: Diptera"); 
            }
			else if (micro == "2")
			{
				Console.WriteLine("1- Autotrophic or 2- Heterotrophic");
				string auto = Console.ReadLine();
				if (auto == "1")
				{
					Console.WriteLine("leaves with 1- parallel veins or 2- netted veins");
					string vein = Console.ReadLine();
					if (vein == "1")
					{
						Console.WriteLine("Your speciman is an American Flag. Kingdom: Plantae, Phylum: Anthophyta, Class: Monocotyledoneae.");
					}
					else if (vein == "2")
					{
						Console.WriteLine("Your speciman is a grape. Kingdom: Plantae, Phylum: Anthophyta, Class: Diccotyledoneae.");
					}
				}
				else if (auto == "2")
				{
					Console.WriteLine("1- Decomposer or 2- Consumer");
					string consume = Console.ReadLine();
					if (consume == "1")
					{
						Console.WriteLine("Your speciman is a mushroom in the Kingdom: Fungi");
					}

					if (consume == "2")
					{
						Console.WriteLine("1- No Backbone or 2- Backbone");
						string backbone = Console.ReadLine();
						if (backbone == "1")
						{
							Console.WriteLine("1- More than 3 pairs of legs or 2- 3 pairs of legs");
							string legs = Console.ReadLine();
							if (legs == "1")
							{
								Console.WriteLine("Your speciman is a spider. Kingdom: Animalia, Phylum: Arthropoda, Class: Arachnida");
							}
							else if (legs == "2")
							{
								Console.WriteLine("1- Transparent wings or 2- Non-transparent wings");
								string wing = Console.ReadLine();
								if (wing == "1")
								{
									Console.WriteLine("1- Can sting or 2- no sting");
									string sting = Console.ReadLine();
									if (sting == "1")
									{
										Console.WriteLine("Your speciman is a wasp. Kingdom: Animalia, Phylum: Arthropoda, Class: Insecta, Order: hymenoptera");
									}
									else if (sting == "2")
									{
										Console.WriteLine("Your speciman is a fly. Kingdom: Animalia, Phylum: Arthropoda, Class: Insecta, Order: Diptera");
									}
								}
								else if (wing == "2")
								{
									Console.WriteLine("1- colorful wings or 2- leathery wings");
									string color = Console.ReadLine();
									if (color == "1")
									{
										Console.WriteLine("Your speciman is a butterfly. Kingdom: Animalia, Phylum: Arthropoda, Class: Insecta, Order: Lepidoptera");
									}
									else if (color == "2")
									{
										Console.WriteLine("1- Hard wing caseing or 2- leathery wing caseing");
										string caseing = Console.ReadLine();
										if (caseing == "1")
										{
											Console.WriteLine("Your speciman is a beetle. Kingdom: Animalia, Phylum: Arthropoda, Class: Insecta, Order: Coleoptera");
										}
										else if (caseing == "2")
										{
											Console.WriteLine("Your speciman is a grashopper. Kingdom: Animalia, Phylum: Arthropoda, Class: Insecta, Order: Orthoptera");
										}
									}
								}
							}
						}
						else if (backbone == "2")
						{
							Console.WriteLine("1- Skin with scales or 2- no scales");
							string scale = Console.ReadLine();
							if (scale == "1")
							{
								Console.WriteLine("1- Gills or 2- lungs");
								string gill = Console.ReadLine();
								if (gill == "1")
								{
									Console.WriteLine("1- Mouth on lower body or 2- mouth on front of body");
									string mouth = Console.ReadLine();
									if (mouth == "1")
									{
										Console.WriteLine("Your speciman is a stingray. Kingdom: Animalia, Phylum: Chordata, Class: Chondrichthes");
									}
									else if (mouth == "2")
									{
										Console.WriteLine("Your speciman is a fish. Kingdom: Animalia, Phylum: Chordata, Class: Osteichthyes");
									}
								}
								else if (gill == "2")
								{
									Console.WriteLine("Your speciman is a snake. Kingdom: Animalia, Phylum: Chordata, Class: Reptilia");
								}
							}
							else if (scale == "2")
							{
								Console.WriteLine("1- Ectothermic or 2- Endothermic");
								string temp = Console.ReadLine();
								if (temp == "1")
								{
									Console.WriteLine("1- Tail or no 2- Tail");
									string tail = Console.ReadLine();
									if (tail == "1")
									{
										Console.WriteLine("Your speciman is a salamander. Kingdom: Animalia, Phylum: Chordata, Class: Amphibia, Order: Caudata");
									}
									else if (tail == "2")
									{
										Console.WriteLine("Your speciman is a toad. Kingdom: Animalia, Phylum: Chordata, Class: Amphibia, Order: Anura");
									}
								}
								else if (temp == "2")
								{
									Console.WriteLine("1- Feathers or 2- hair");
									string hair = Console.ReadLine();
									if (hair == "1")
									{
										Console.WriteLine("Your speciman is a swan. Kingdom: Animalia, Phylum: Chordata, Class: Aves");
									}
									else if (hair == "2")
									{
										Console.WriteLine("1- Hooves or 2- no Hooves");
										string hoof = Console.ReadLine();
										if (hoof == "1")
										{
											Console.WriteLine("1- Non-cloven hooves or 2- Cloven hooves");
											string cloven = Console.ReadLine();
											if (cloven == "1")
											{
												Console.WriteLine("Your speciman is a zebra. Kingdom: Animalia, Phylum: Chordata, Class: Mammalia, Order: Perissodactyla");
											}
											else if (cloven == "2")
											{
												Console.WriteLine("Your speciman is a deer. Kingdom: Animalia, Phylum: Chordata, Class: Mammalia, Order: Artiodactyla");
											}
										}
										else if (hoof == "2")
										{
											Console.WriteLine("1- Carnivore or 2- Herbivore");
											string food = Console.ReadLine();
											if (food == "1")
											{
												Console.WriteLine("1- Teeth or 2- no Teeth");
												string tooth = Console.ReadLine();
												if (tooth == "1")
												{
													Console.WriteLine("Your speciman is a lion. Kingdom: Animalia, Phylum: Chordata, Class: Mammalia, Order: Carnivora");
												}
												else if (tooth == "2")
												{
													Console.WriteLine("Your speciman is a shrew. Kingdom: Animalia, Phylum: Chordata, Class: Mammalia, Order: Insectivora");
												}
											}
											else if (food == "2")
											{
												Console.WriteLine("1- Chisel like front teeth or 2- Non-chisel like teeth.");
												string chisel = Console.ReadLine();
												if (chisel == "1")
												{
													Console.WriteLine("1- Legs for crawling or 2- hind legs for leaping");
													string legs = Console.ReadLine();
													if (legs == "1")
													{
														Console.WriteLine("Your speciman is a chipmunk. Kingdom: Animalia, Phylum: Chordata, Class: Mammalia, Order: Rodentia");
													}
													else if (legs == "2")
													{
														Console.WriteLine("Your speciman is a hare. Kingdom: Animalia, Phylum: Chordata, Class: Mammalia, Order: Lagomorpha");
													}
												}
												else if (chisel == "2")
												{
													Console.WriteLine("1- trunk or 2- opposable thumbs");
													string oppos = Console.ReadLine();
													if (oppos == "1")
													{
														Console.WriteLine("Your speciman is an elephant. Kingdom: Animalia, Phylum: Chordata, Class: Mammalia, Order: Proboscidea");
													}
													else if (oppos == "2")
													{
														Console.WriteLine("Your speciman is a gibbon. Kingdom: Animalia, Phylum: Chordata, Class: Mammalia, Order: Primates");
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
		}
	}
}