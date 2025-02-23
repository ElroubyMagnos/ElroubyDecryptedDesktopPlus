#pragma once
#include <iostream>
#include <string>
#include <fstream>
#include <vector>
using namespace std;
class Crypto
{
public:

    void xorEncrypt(const std::string& inputFile, const std::string& encryptedFile, char key);

    void xorDecrypt(const std::string& encryptedFile, const std::string& decryptedFile, char key);
};

