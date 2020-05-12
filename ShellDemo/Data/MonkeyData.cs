using ShellDemo.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShellDemo.Data
{
    public static class MonkeyData
    {
        public static IList<Animal> Monkeys { get; private set; }

        static MonkeyData()
        {
            Monkeys = new List<Animal>();

            Monkeys.Add(new Animal
            {
                Name = "Baboon"
            });

            Monkeys.Add(new Animal
            {
                Name = "Capuchin Monkey"
            });

            Monkeys.Add(new Animal
            {
                Name = "Blue Monkey"
            });

            Monkeys.Add(new Animal
            {
                Name = "Squirrel Monkey"
            });

            Monkeys.Add(new Animal
            {
                Name = "Golden Lion Tamarin"
            });

            Monkeys.Add(new Animal
            {
                Name = "Howler Monkey"
            });

            Monkeys.Add(new Animal
            {
                Name = "Japanese Macaque"
            });

            Monkeys.Add(new Animal
            {
                Name = "Mandrill"
            });

            Monkeys.Add(new Animal
            {
                Name = "Proboscis Monkey"
            });

            Monkeys.Add(new Animal
            {
                Name = "Red-shanked Douc"
            });

            Monkeys.Add(new Animal
            {
                Name = "Gray-shanked Douc"
            });

            Monkeys.Add(new Animal
            {
                Name = "Golden Snub-nosed Monkey"
            });

            Monkeys.Add(new Animal
            {
                Name = "Black Snub-nosed Monkey"
            });

            Monkeys.Add(new Animal
            {
                Name = "Tonkin Snub-nosed Monkey"
            });

            Monkeys.Add(new Animal
            {
                Name = "Thomas's Langur"
            });

            Monkeys.Add(new Animal
            {
                Name = "Purple-faced Langur"
            });

            Monkeys.Add(new Animal
            {
                Name = "Gelada"
            });
        }
    }
}
