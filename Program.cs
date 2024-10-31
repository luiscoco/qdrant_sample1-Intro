using Qdrant.Client;
using Qdrant.Client.Grpc;
using System.Net.Sockets;
using static Qdrant.Client.Grpc.Conditions;

//docker run -p 6333:6333 - p 6334:6334 ^
//-v C:\\Users\\LEnriquez\\luiscocoenriquezvector\\qdrant_storage:/ qdrant / storage:z ^
//qdrant / qdrant

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

Console.WriteLine(searchResult1);

var searchResult2 = await client.QueryAsync(
    collectionName: "test_collection",
    query: new float[] { 0.2f, 0.1f, 0.9f, 0.7f },
    filter: MatchKeyword("city", "London"),
    limit: 3,
    payloadSelector: true
);

Console.WriteLine(searchResult2);