# Getting Started with Qdrant and .NET: Sample Code for Vector Search with gRPC

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

Now we execute the command to run qdrant docker container

```
docker run -p 6333:6333 - p 6334:6334 ^
-v C:\\Users\\luisc\\luiscocoenriquezvector\\qdrant_storage:/ qdrant / storage:z ^
qdrant / qdrant
```

## 5.

