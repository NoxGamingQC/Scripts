#!/bin/bash

# Make sure to modify the missing package section, the location folder and the key location.

echo "Accessing website folder ..."
cd /path_to_your_project
clear

echo "Setting up ssh"
ssh-add /path_to_ssh_key
ssh-agent bash -c 'ssh-add /path_to_ssh'

echo "Comparing local and remote branch"
BRANCH="master"
git remote update

LAST_UPDATE=`git show --no-notes --format=format:"%H" $BRANCH | head -n 1`
LAST_COMMIT=`git show --no-notes --format=format:"%H" origin/$BRANCH | head -n 1`

if [ $LAST_COMMIT != $LAST_UPDATE ]; then
    echo "Getting data from GitHub ..."
    ssh-agent bash -c 'ssh-add /somewhere/yourkey; git pull origin master
    clear

    echo "Install any missing package ..."
    npm install
    clear

    echo "Building packages ..."
    npm run build
    clear
    echo "Update completed."
else
    echo "Already up to date."
fi
