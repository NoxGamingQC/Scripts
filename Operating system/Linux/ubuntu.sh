#!/bin/bash

clear

echo -e "\n========================= Nox's automated Ubuntu setup =========================\n"

echo -e "Do you want to add support for Windows executable? (Y/N)"

sleep 5

echo -e "\e[93mInstalling Wine ...\e[0m"
sudo dpkg --add-architecture i386
sudo mkdir -pm755 /etc/apt/keyrings
wget -O - https://dl.winehq.org/wine-builds/winehq.key | sudo gpg --dearmor -o /etc/apt/keyrings/winehq-archive.key -
sudo apt update
sudo apt install --install-recommends winehq-stable
clear
echo -e "\e[92mWine Installed.\e[0m"


echo -e "\e[93mInstalling support for .exe icon ...\e[0m"
sudo apt-get install exe-thumbnailer
clear
echo -e "\e[92m.exe icon support completed.\e[0m"

sleep 5
