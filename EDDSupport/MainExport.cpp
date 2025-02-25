#include "pch.h"
#include "Crypto.h"
#include <iostream>
#include <filesystem>
#include <vector>
#include <fstream>
#include <string>
#include <cstring>

namespace fs = filesystem;

// دالة لإنشاء المجلدات ونسخ الملفات مع تعديل محتواها
string xorEncrypt(const string& text, char key) {
    string encryptedText = text;
    for (char& c : encryptedText) {
        c ^= key;
    }
    return encryptedText;
}

const char XOR_KEY = 'A'; // مفتاح التشفير باستخدام XOR

// تصدير الدوال لاستخدامها مع C#
extern "C" __declspec(dllexport) void CopyAndEncryptFolder(const char* sourcePath, const char* destPath);
extern "C" __declspec(dllexport) void CopyAndDecryptFolder(const char* sourcePath, const char* destPath);

void EncryptFile(const std::string& sourceFile, const std::string& destFile) {
    std::ifstream input(sourceFile, std::ios::binary);
    std::ofstream output(destFile + ".rouby", std::ios::binary);

    if (!input || !output) {
        std::cerr << "Failed to open file: " << sourceFile << std::endl;
        return;
    }

    char buffer;
    while (input.get(buffer)) {
        buffer ^= XOR_KEY;  // تشفير XOR
        output.put(buffer);
    }

    input.close();
    output.close();
}

void DecryptFile(const std::string& sourceFile, const std::string& destFile) {
    if (sourceFile.find(".rouby") == std::string::npos) {
        std::cerr << "Skipping non-encrypted file: " << sourceFile << std::endl;
        return;
    }

    std::ifstream input(sourceFile, std::ios::binary);
    std::ofstream output(destFile, std::ios::binary);

    if (!input || !output) {
        std::cerr << "Failed to open file: " << sourceFile << std::endl;
        return;
    }

    char buffer;
    while (input.get(buffer)) {
        buffer ^= XOR_KEY;  // فك التشفير بنفس المفتاح
        output.put(buffer);
    }

    input.close();
    output.close();
}

void CopyAndEncryptFolder(const char* sourcePath, const char* destPath) {
    try {
        fs::path src(sourcePath);
        fs::path dst(destPath);

        if (!fs::exists(src) || !fs::is_directory(src)) {
            std::cerr << "Source folder not found!" << std::endl;
            return;
        }

        fs::create_directories(dst);

        for (const auto& entry : fs::recursive_directory_iterator(src)) {
            const auto& path = entry.path();
            auto relativePath = fs::relative(path, src);
            auto destFilePath = dst / relativePath;

            if (fs::is_directory(path)) {
                fs::create_directories(destFilePath);
            }
            else if (fs::is_regular_file(path)) {
                EncryptFile(path.string(), destFilePath.string());
            }
        }

        std::cout << "Folder copied and encrypted successfully!\n";
    }
    catch (const std::exception& ex) {
        std::cerr << "Error: " << ex.what() << std::endl;
    }
}

void CopyAndDecryptFolder(const char* sourcePath, const char* destPath) {
    try {
        fs::path src(sourcePath);
        fs::path dst(destPath);

        if (!fs::exists(src) || !fs::is_directory(src)) {
            std::cerr << "Source folder not found!" << std::endl;
            return;
        }

        fs::create_directories(dst);

        for (const auto& entry : fs::recursive_directory_iterator(src)) {
            const auto& path = entry.path();
            auto relativePath = fs::relative(path, src);
            auto destFilePath = dst / relativePath;

            if (fs::is_directory(path)) {
                fs::create_directories(destFilePath);
            }
            else if (fs::is_regular_file(path)) {
                std::string destWithoutExtension = destFilePath.string();
                if (destWithoutExtension.size() > 6 && destWithoutExtension.substr(destWithoutExtension.size() - 6) == ".rouby") {
                    destWithoutExtension = destWithoutExtension.substr(0, destWithoutExtension.size() - 6);
                }
                DecryptFile(path.string(), destWithoutExtension);
            }
        }

        std::cout << "Folder copied and decrypted successfully!\n";
    }
    catch (const std::exception& ex) {
        std::cerr << "Error: " << ex.what() << std::endl;
    }
}

extern "C" __declspec(dllexport) void CreateStructureFromPaths(const vector<string>& paths) {
    try {
        for (const auto& path : paths) {
            fs::path currentPath(path);

            if (currentPath.has_extension()) {
                // إذا كان المسار ملفًا
                fs::create_directories(currentPath.parent_path()); // إنشاء المجلدات
                ofstream file(path); // إنشاء الملف
                if (file.is_open()) {
                    cout << "تم إنشاء الملف: " << path << endl;
                    file.close();
                }
                else {
                    cerr << "تعذر إنشاء الملف: " << path << endl;
                }
            }
            else {
                // إذا كان المسار مجلدًا
                if (fs::create_directories(currentPath)) {
                    cout << "تم إنشاء المجلد: " << path << endl;
                }
                else {
                    cout << "المجلد موجود بالفعل: " << path << endl;
                }
            }
        }
    }
    catch (const fs::filesystem_error& e) {
        cerr << "خطأ: " << e.what() << endl;
    }
}

extern "C" __declspec(dllexport) char** GetAllPaths(const char* directoryPath, int* count) {
    vector<string> paths;

    try {
        string path(directoryPath);
        if (fs::exists(path) && fs::is_directory(path)) {
            for (const auto& entry : fs::recursive_directory_iterator(path)) {
                paths.push_back(entry.path().string());
            }
        }
        else {
            cerr << "المسار غير موجود أو ليس مجلدًا." << endl;
            *count = 0;
            return nullptr;
        }
    }
    catch (const fs::filesystem_error& e) {
        cerr << "خطأ: " << e.what() << endl;
        *count = 0;
        return nullptr;
    }

    // إعداد C-style array
    *count = static_cast<int>(paths.size());
    char** result = new char* [*count];

    for (int i = 0; i < *count; ++i) {
        result[i] = new char[paths[i].size() + 1];
        strcpy_s(result[i], paths[i].size() + 1, paths[i].c_str());
    }

    return result;
}

// دالة لتحرير الذاكرة بعد الاستخدام
extern "C" __declspec(dllexport) void FreePaths(char** paths, int count) {
    for (int i = 0; i < count; ++i) {
        delete[] paths[i];
    }
    delete[] paths;
}


extern "C" __declspec(dllexport) bool ValidateUserPassword(const wstring& username, const wstring& password) {
    HANDLE hToken = nullptr;
    wstring domain = L".";

    // محاولة تسجيل الدخول
    BOOL success = LogonUserW(
        username.c_str(),         // اسم المستخدم
        domain.c_str(),           // الدومين (أو . للجهاز المحلي)
        password.c_str(),         // كلمة المرور
        LOGON32_LOGON_NETWORK,    // نوع تسجيل الدخول
        LOGON32_PROVIDER_DEFAULT, // مزود تسجيل الدخول
        &hToken
    );

    if (success) {
        CloseHandle(hToken);
        return true;
    }
    else {
        DWORD error = GetLastError();
        wcout << L"❌ فشل تسجيل الدخول، رمز الخطأ: " << error << endl;
        return false;
    }
}

extern "C" __declspec(dllexport) char** ListFilesAndFolders(const char* path, int* count) {
    static vector<string> entries;
    entries.clear();

    try {
        for (const auto& entry : fs::directory_iterator(path)) {
            entries.push_back(entry.path().string());
        }
    }
    catch (const exception& e) {
        cerr << "خطأ: " << e.what() << endl;
    }

    *count = entries.size();
    char** result = new char* [*count];

    for (size_t i = 0; i < entries.size(); ++i) {
        result[i] = new char[entries[i].length() + 1];  // تخصيص الذاكرة
        strcpy_s(result[i], entries[i].length() + 1, entries[i].c_str());  // النسخ الآمن
    }

    return result;
}

extern "C" __declspec(dllexport) void FreeStringArray(char** array, int count) {
    for (int i = 0; i < count; ++i) {
        delete[] array[i];
    }
    delete[] array;
}


extern "C" __declspec(dllexport) void EncryptAll(char* Input, char* output)
{
	Crypto C = Crypto();

	C.xorEncrypt(Input, output, 'A');
}

extern "C" __declspec(dllexport) void DecryptAll(char* Input, char* output)
{
	Crypto C = Crypto();

	C.xorDecrypt(Input, output, 'A');
}