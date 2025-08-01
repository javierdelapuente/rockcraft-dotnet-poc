sudo snap install dotnet-sdk-80
sudo snap install dotnet-runtim-80

/snap/dotnet-sdk-80/current/usr/bin/dotnet
/snap/dotnet-sdk-80/43/usr/bin/dotnet build

??

https://github.com/canonical/dotnet-snap
https://github.com/canonical/dotnet-content-snaps




sudo rockcraft.skopeo --insecure-policy copy oci-archive:my-rock-name_0.1_amd64.rock docker-daemon:my-rock-name:latest

docker run --rm --name dotnet -p 5000:5000 my-rock-name:latest
docker exec -ti dotnet bash 