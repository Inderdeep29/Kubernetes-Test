# Kubernetes-Test
## Install Docker Cli
1. Enable Windows Features: Containers and Hyper-V
2. Download the static binary archive. Go to https://download.docker.com/win/static/stable/x86_64 and select the latest version from the list.
3. Extract the binaries somewhere and add the folder to PATH environment variable.

## Install Kubernetes
1. Open Powershell and type "winget install minikube"
2. Close powershell and open it with admin rights, type the command: "minikube start --container-runtime=docker --vm=true"

## Install Kubectl
Follow this guide(Download binary and add to PATH): https://kubernetes.io/docs/tasks/tools/install-kubectl-windows/

After Installation, run the following:

kubectl create clusterrolebinding permissive-binding --clusterrole=cluster-admin --user=admin --user=kubelet --group=system:serviceaccounts

## Post Installation Steps
1. In Powershell, type dockerd, this will start the docker daemon.
2. Open another powershell and Cd to this Repo
3. Run the following command for docker cli to point to minikube: "& minikube -p minikube docker-env --shell powershell | Invoke-Expression"
4. Run the following commands one by one:
    - docker build . -t gateway:latest -f Gateway/Dockerfile
    - docker build . -t content:latest -f Content/Dockerfile
    - docker build . -t product:latest -f Product/Dockerfile
  This will create the images under minikube.
5. Now cd Into "/Kubernetes Configs" folder inside this repo and run the following command
    - kubectl apply -f content-api-service.yaml,db-service.yaml,gateway-service.yaml,product-api-service.yaml,content-api-deployment.yaml,db-deployment.yaml,db-persistentvolumeclaim.yaml,gateway-deployment.yaml,product-api-deployment.yaml
6. In powershell, run "minikube service gateway" and it should open the gateway address in browser "x.x.x.x:30100", to test APIs, run "x.x.x.x:30100/content-service/Test1", "x.x.x.x:30100/content-service/GetWeatherTypes", "x.x.x.x:30100/product-service"
7. To stop the services and pods, run:
    - kubectl delete -f content-api-service.yaml,db-service.yaml,gateway-service.yaml,product-api-service.yaml,content-api-deployment.yaml,db-deployment.yaml,db-persistentvolumeclaim.yaml,gateway-deployment.yaml,product-api-deployment.yaml


# Others
- To Generate kubernetes .yaml files from Docker compose: "wsl kompose convert"

# OLD - DO NOT FOLLOW STEPS BELOW, THESE ARE JUST FOR REFERENCE FOR CONFIGURING THINGS VIA UBUNTU SUBSYSTEM :
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
