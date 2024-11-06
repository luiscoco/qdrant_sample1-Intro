# Getting Started with Qdrant and .NET: Sample Code for Vector Search with gRPC

## 1. 

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

## 2. Creating a new Cluster in Qdrant and the API Key

We navigate to the Overview option or to the Cluster option and we create a new cluster

![image](https://github.com/user-attachments/assets/49afb267-7033-43b2-9b49-7bd7a2872fe7)

We copy the API Key to access to the Cluster Dashboard

![image](https://github.com/user-attachments/assets/03f96a32-aa9b-49ef-9947-4c58171d8c7b)

We navigate to the Cluster web page and we select the Dashboard option

![image](https://github.com/user-attachments/assets/f7d1217a-fc1d-4b95-a4b2-eb31e707aa45)

We navigate into the Dashboard after accessing with the API Key

![image](https://github.com/user-attachments/assets/fac943ae-33fd-439c-bb23-c74ca22d6c42)

## 3. 

## 4. Run qdrant in a Docker container

We first have to view the user folder name and set in in the command:

![image](https://github.com/user-attachments/assets/f1ec286f-9c8d-4277-85e0-fee34451ac8f)

Now we execute the command to run qdrant docker container

```
docker run -p 6333:6333 - p 6334:6334 ^
-v C:\\Users\\luisc\\luiscocoenriquezvector\\qdrant_storage:/ qdrant / storage:z ^
qdrant / qdrant
```
