
using _04.PokemonTrainer;

List<Trainer> trainers = new List<Trainer>();

string input = Console.ReadLine();

while (input != "Tournament")
{
    string[] data = input.Split(" ");

    string trainerName = data[0];
    string pokemonName = data[1];
    string pokemonElement = data[2];
    int pokemonHealth = int.Parse(data[3]);

    Pokemon newPokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);

    if (trainers.Any(t => t.Name == trainerName))
    {
        Trainer existingTrainer = trainers.FirstOrDefault(t => t.Name == trainerName);

        existingTrainer.Pokemons.Add(newPokemon);
    }
    else
    {
        Trainer newTrainer = new Trainer(trainerName);

        newTrainer.Pokemons.Add(newPokemon);

        trainers.Add(newTrainer);
    }

    input = Console.ReadLine();
}

string element = Console.ReadLine();

while (element != "End")
{
    foreach (Trainer currentTrainer in trainers)
    {
        if (currentTrainer.Pokemons.Any(p => p.Element == element))
        {
            currentTrainer.NumberOfBadges++;
        }
        else
        {
            foreach (Pokemon pokemon in currentTrainer.Pokemons)
            {
                pokemon.Health -= 10;
            }

            currentTrainer.Pokemons.RemoveAll(p => p.Health <= 0);
        }
    }

    element = Console.ReadLine();
}

foreach (Trainer trainer in trainers.OrderByDescending(t => t.NumberOfBadges))
{
    Console.WriteLine($"{trainer.Name} {trainer.NumberOfBadges} {trainer.Pokemons.Count}");
}