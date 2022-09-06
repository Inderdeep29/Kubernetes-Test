# Kubernetes-Test

## Install Docker:
Install Docker: Follow guide on: https://betterprogramming.pub/how-to-install-docker-without-docker-desktop-on-windows-a2bbb65638a1

## Install Kubernetes
Follow guide on: https://minikube.sigs.k8s.io/docs/start/
Note: You need to install this on Ubuntu you created while installing Docker so chose Linux steps from above link.

## Post Installation Steps
1. Cd to this Repo
2. Run the following commands one by one:
    - wsl docker build . -t gateway:latest -f Gateway/Dockerfile
    - wsl docker build . -t content:latest -f Content/Dockerfile
    - wsl docker build . -t product:latest -f Product/Dockerfile
  This will create the images.
3. Now run the following commands to load these images to minikube repo
    - wsl minikube image load gateway:latest
    - wsl minikube image load content:latest
    - wsl minikube image load product:latest
4. Now cd Into "/Kubernetes Configs" folder inside this repo and run the following command
    - kubectl apply -f ingress.yaml,content-api-service.yaml,db-service.yaml,gateway-service.yaml,product-api-service.yaml,content-api-deployment.yaml,db-deployment.yaml,db-persistentvolumeclaim.yaml,gateway-deployment.yaml,product-api-deployment.yaml


# Others
- To Generate kubernetes .yaml files from Docker compose: "wsl kompose convert"
