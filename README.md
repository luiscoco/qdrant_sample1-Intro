# Getting Started with Qdrant and .NET: Sample Code for Vector Search with gRPC

This sample demonstrates a typical workflow of creating a vector collection, adding data points with metadata, and performing similarity searches with optional filtering based on metadata

## 1. Introduction to Qdrant

**Qdrant** is an open-source, high-performance **vector search database** specifically designed for applications that require searching, filtering, and querying large collections of unstructured data, such as text, images, or embeddings (dense vectors)

It uses **Approximate Nearest Neighbor (ANN)** algorithms and provides a scalable and efficient way to handle similarity search across massive datasets, making it ideal for applications in machine learning, recommendation systems, semantic search, and natural language processing

**Qdrant** helps businesses and developers leverage **vector embeddings** in real-world applications, offering robust performance and flexibility for working with high-dimensional data

## 2. How to Sign Up and Log In to Qdrant: A Step-by-Step Guide

We navigate to the qdrant web page: https://qdrant.tech/

![image](https://github.com/user-attachments/assets/1916e362-2697-4779-9ab3-a958cd416d1f)

We press the Get Start button 

![image](https://github.com/user-attachments/assets/34543537-ed42-4a44-8945-ad168483e909)

We enter the e-mail and press the SignUP button 

![image](https://github.com/user-attachments/assets/329b23d1-3a03-42de-8d4a-fbe221441498)

We will receive the verification code in our e-mail account

We input the verification code and press Sing UP button

![image](https://github.com/user-attachments/assets/d007beb1-4245-460d-9823-b15350d6bebb)

We enter in the main landing page 

![image](https://github.com/user-attachments/assets/2b0b5067-0997-4fe7-994b-7ef84b652b65)

## 3. Creating a new Cluster in Qdrant and the API Key

We navigate to the Overview option or to the Cluster option and we create a new cluster

![image](https://github.com/user-attachments/assets/49afb267-7033-43b2-9b49-7bd7a2872fe7)

We copy the **API Key** to access to the **Cluster Dashboard**

![image](https://github.com/user-attachments/assets/03f96a32-aa9b-49ef-9947-4c58171d8c7b)

We navigate to the **Cluster** web page and we select the **Dashboard** option

![image](https://github.com/user-attachments/assets/f7d1217a-fc1d-4b95-a4b2-eb31e707aa45)

We navigate into the **Dashboard** after accessing with the **API Key**

If we select in the first menu option we see the **Welcome Page** with some samples

![image](https://github.com/user-attachments/assets/eda8f1c5-a66c-4088-a3f9-a689137bed1d)

In the second option we see the **Console**

![image](https://github.com/user-attachments/assets/d912882c-dda7-402f-99b3-589462ce6e1a)

In the third menu option we access the **Collections**

![image](https://github.com/user-attachments/assets/fac943ae-33fd-439c-bb23-c74ca22d6c42)

We can also access to the **Tutorial** web page

![image](https://github.com/user-attachments/assets/b3d16bb8-07f0-4d47-b260-9a6fcec9dcb2)

And also we can visit the **DataSets** web page

![image](https://github.com/user-attachments/assets/1c0e29b8-1bb8-496f-91c6-7f20e34ab3ca)

## 4. Run qdrant in a Docker container

We first have to view the user folder name and set in in the command:

![image](https://github.com/user-attachments/assets/f1ec286f-9c8d-4277-85e0-fee34451ac8f)

Now we execute the command to **run qdrant docker container**

```
docker run -p 6333:6333 -p 6334:6334 ^
-v C:\Users\luisc\luiscocoenriquezvector\qdrant_storage:/qdrant/storage:z ^
qdrant/qdrant
```

![image](https://github.com/user-attachments/assets/b91b727f-c792-47ac-b7db-bad12e20eddf)

We verify in **Docker Desktop**

![image](https://github.com/user-attachments/assets/cfd8b8aa-04e6-44e8-aab6-94b5ed0a32b1)

![image](https://github.com/user-attachments/assets/253e659a-58e8-48ef-b198-15c1fa7d1951)

## 5. For creating this repo sample we start creating a C# console application with Visual Studio 2022 and .NET 9

This C# code demonstrates how to use the **Qdrant** vector search engine with a **gRPC** interface

**Qdrant** is a high-performance **vector database** optimized for AI-driven applications

We first run Visual Studio 2022 Community Edition and Create a New Project

![image](https://github.com/user-attachments/assets/84ef792c-a675-442e-b8ad-18f8e41e32a1)

We select the console C# project and press the Next button

![image](https://github.com/user-attachments/assets/3443d446-676c-4ab5-bcea-386f4fa67bb8)

We input the project name and location and press the Next button

![image](https://github.com/user-attachments/assets/56e72654-d598-47b9-b47c-add7bb2f837f)

We select the framework .NET 9 and press the Create button

![image](https://github.com/user-attachments/assets/db8ad08f-7e7c-4aa4-95f0-318253dcaf1b)

## 6. We load the Nuget package

![image](https://github.com/user-attachments/assets/6f460969-77fb-4069-aae6-d2a61847b29c)

## 7. We input the source code in the Program.cs file

Here's a breakdown of what the code does:

**Client Initialization**: A **QdrantClient** instance is created to connect to **Qdrant running** on **localhost** on **port 6334**

```csharp
var client = new QdrantClient("localhost", 6334);
```

This client uses the **gRPC** interface provided by Qdrant for communication

**Creating a Collection**: **CreateCollectionAsync** is called to create a new collection named "test_collection" in Qdrant

```csharp
await client.CreateCollectionAsync(collectionName: "test_collection", vectorsConfig: new VectorParams
{
    Size = 4,
    Distance = Distance.Dot
});
```

The collection is configured with vector parameters:

**Size = 4** indicates each vector in this collection has 4 dimensions

**Distance = Distance.Dot** specifies the distance function for similarity as "Dot Product."

**Inserting Data (Upsert)**:

**UpsertAsync**: inserts or updates points (vector data points) in "test_collection"

```csharp
var operationInfo = await client.UpsertAsync(collectionName: "test_collection", points: new List<PointStruct>
{
    new()
    {
        Id = 1,
            Vectors = new float[]
            {
                0.05f, 0.61f, 0.76f, 0.74f
            },
            Payload = {
                ["city"] = "Berlin"
            }
    },
    new()
    {
        Id = 2,
            Vectors = new float[]
            {
                0.19f, 0.81f, 0.75f, 0.11f
            },
            Payload = {
                ["city"] = "London"
            }
    },
    new()
    {
        Id = 3,
            Vectors = new float[]
            {
                0.36f, 0.55f, 0.47f, 0.94f
            },
            Payload = {
                ["city"] = "Moscow"
            }
    },
    // Truncated
});
```

Each point contains:

An **Id** (identifier).

A **Vectors array** with four float values, representing the vector

A **Payload** dictionary with key-value pairs for additional . For instance, each point here has a "city" field with a city name as its value (e.g., "Berlin", "London")

**operationInfo logs** information about the insertion operation

**Querying the Collection**: **QueryAsync** searches for vectors in "test_collection" based on similarity to a given query vector (new float[] { 0.2f, 0.1f, 0.9f, 0.7f })

The **first query** (searchResult1) retrieves the top 3 similar vectors to the query vector

```csharp
var searchResult1 = await client.QueryAsync(
    collectionName: "test_collection",
    query: new float[] { 0.2f, 0.1f, 0.9f, 0.7f },
    limit: 3
);
```

The **second query** (searchResult2) filters results to return vectors with a "city" field that matches "London", also limiting results to the top 3 and including payload data in the response

```csharp
var searchResult2 = await client.QueryAsync(
    collectionName: "test_collection",
    query: new float[] { 0.2f, 0.1f, 0.9f, 0.7f },
    filter: MatchKeyword("city", "London"),
    limit: 3,
    payloadSelector: true
);
```
We can verify and review the whole code:

```csharp
using Qdrant.Client;
using Qdrant.Client.Grpc;
using System.Net.Sockets;
using static Qdrant.Client.Grpc.Conditions;

// The C# client uses Qdrant's gRPC interface
var client = new QdrantClient("localhost", 6334);

await client.CreateCollectionAsync(collectionName: "test_collection", vectorsConfig: new VectorParams
{
    Size = 4,
    Distance = Distance.Dot
});

var operationInfo = await client.UpsertAsync(collectionName: "test_collection", points: new List<PointStruct>
{
    new()
    {
        Id = 1,
            Vectors = new float[]
            {
                0.05f, 0.61f, 0.76f, 0.74f
            },
            Payload = {
                ["city"] = "Berlin"
            }
    },
    new()
    {
        Id = 2,
            Vectors = new float[]
            {
                0.19f, 0.81f, 0.75f, 0.11f
            },
            Payload = {
                ["city"] = "London"
            }
    },
    new()
    {
        Id = 3,
            Vectors = new float[]
            {
                0.36f, 0.55f, 0.47f, 0.94f
            },
            Payload = {
                ["city"] = "Moscow"
            }
    },
    // Truncated
});

Console.WriteLine(operationInfo);

var searchResult1 = await client.QueryAsync(
    collectionName: "test_collection",
    query: new float[] { 0.2f, 0.1f, 0.9f, 0.7f },
    limit: 3
);

Console.WriteLine("Top 3 similar vectors to the query vector.");
Console.WriteLine("SearchResult1: " + searchResult1);

var searchResult2 = await client.QueryAsync(
    collectionName: "test_collection",
    query: new float[] { 0.2f, 0.1f, 0.9f, 0.7f },
    filter: MatchKeyword("city", "London"),
    limit: 3,
    payloadSelector: true
);

Console.WriteLine("Filters results to return vectors with a city field that matches London");
Console.WriteLine("SearchResult2: " + searchResult2);
```

## 8. We run the application and see the results 

**Output**: operationInfo, searchResult1, and searchResult2 are printed to the console to display the results of each operation

The **first query** (searchResult1) retrieves the **top 3 similar vectors to the query vector**

The **second query** (searchResult2) **filters** results to return vectors with a **"city"** field that **matches "London"**, also limiting results to the top 3 and including payload data in the response

![image](https://github.com/user-attachments/assets/b3f896dd-fb08-4fcf-8791-db78b64ad15d)



