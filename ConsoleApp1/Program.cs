using System;
using System.Collections.Generic;

public class DocumentStore
{
    private readonly List<string> documents = new List<string>();
    private readonly int capacity;

    public DocumentStore(int capacity)
    {
        this.capacity = capacity;
    }

    public int Capacity { get { return capacity; } }

    public IReadOnlyList<string> Documents { get { return documents.AsReadOnly(); } }

    public void AddDocument(string document)
    {
        if (documents.Count + 1 > capacity)
            throw new InvalidOperationException();

        documents.Add(document);
    }

    public override string ToString()
    {
        return $"Document store: {documents?.Count}/{capacity}";
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        DocumentStore documentStore = new DocumentStore(2);
        documentStore.AddDocument("item");
        documentStore.AddDocument("item2");
        documentStore.AddDocument("item3");
        Console.WriteLine(documentStore);
    }
}