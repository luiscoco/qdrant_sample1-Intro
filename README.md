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




## 2. Run qdrant in a Docker container

We first have to view the user folder name and set in in the command:

![image](https://github.com/user-attachments/assets/f1ec286f-9c8d-4277-85e0-fee34451ac8f)

Now we execute the command to run qdrant docker container

```
docker run -p 6333:6333 - p 6334:6334 ^
-v C:\\Users\\luisc\\luiscocoenriquezvector\\qdrant_storage:/ qdrant / storage:z ^
qdrant / qdrant
```
