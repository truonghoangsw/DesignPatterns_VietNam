using System;
using System.Collections.Generic;

namespace BuilderPatterns
{
    public class Persons
    {
        public string Name, Position;
    }

    public sealed class PersonBuilder
    {
        public readonly List<Action<Persons>> Actions = new List<Action<Persons>>();
        public PersonBuilder Called(string name)
        {
            Actions.Add(p => { p.Name = name; });
            return this;
        }

        public Persons Build()
        {
            var p = new Persons();
            Actions.ForEach(a => a(p));
            return p;
        }
        private PersonBuilder AddAction(Action<Persons> action)
        {
            Actions.Add(action);
            return this;
        }
    }
    public static class PersonBuilderExtensions
    {
        public static PersonBuilder WorksAsA
            (this PersonBuilder builder, string position)
        {
            builder.Actions.Add(p =>
            {
                p.Position = position;
            });
            return builder;
        }
    }

}