#include "pch.h"
#include "Crypto.h"

void Crypto::xorEncrypt(const std::string& inputFile, const std::string& encryptedFile, char key) {
    std::ifstream inFile(inputFile, std::ios::binary);
    std::ofstream outFile(encryptedFile, std::ios::binary);

    if (!inFile || !outFile) {
        std::cerr << "Error opening files!\n";
        return;
    }

    std::vector<char> buffer((std::istreambuf_iterator<char>(inFile)), std::istreambuf_iterator<char>());

    for (char& c : buffer) {
        c ^= key;  // ÊÔÝíÑ XOR
    }

    outFile.write(buffer.data(), buffer.size());
}

void Crypto::xorDecrypt(const std::string& encryptedFile, const std::string& decryptedFile, char key) {
    std::ifstream inFile(encryptedFile, std::ios::binary);
    std::ofstream outFile(decryptedFile, std::ios::binary);

    if (!inFile || !outFile) {
        std::cerr << "Error opening files!\n";
        return;
    }

    std::vector<char> buffer((std::istreambuf_iterator<char>(inFile)), std::istreambuf_iterator<char>());

    for (char& c : buffer) {
        c ^= key;  // Ýß ÇáÊÔÝíÑ ÈäÝÓ ãÝÊÇÍ XOR
    }

    outFile.write(buffer.data(), buffer.size());
}