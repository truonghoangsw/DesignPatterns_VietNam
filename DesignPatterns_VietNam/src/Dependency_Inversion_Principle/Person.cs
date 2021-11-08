using System;
using System.Collections.Generic;
using System.Linq;

namespace Dependency_Inversion_Principle
{
    public enum Relationship
    {
        Parent,
        Child
    }

    public class Person
    {
        public string Name { get; set; }
    }

    public interface IRelationshipsBrowser
    {
        IEnumerable<Person> FindAllChildrenOf(string name);
    }

    public class Relationships : IRelationshipsBrowser
    {
        private List<(Person, Relationship, Person)> relations = new List<(Person, Relationship, Person)>();

        public void AddParentAndChild(Person parent, Person child)
        {
            relations.Add((parent, Relationship.Parent, child));
            relations.Add((child, Relationship.Child, parent));
        }

        public IEnumerable<Person> FindAllChildrenOf(string name)
        {
            return relations.Where(p => p.Item1.Name == name).Select(p => p.Item3);
        }
    }

    public class RelationShipsBeforRefactor
    {
        private List<(Person, Relationship, Person)> relations = new List<(Person, Relationship, Person)>();

        public void AddParentAndChild(Person parent, Person child)
        {
            relations.Add((parent,Relationship.Parent,child));
            relations.Add((child, Relationship.Child, parent));
        }
    }
}