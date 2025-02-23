#include "pch.h"
#include "Crypto.h"
#include <iostream>
#include <filesystem>
#include <vector>

#include <iostream>
#include <vector>
#include <string>
#include <filesystem>
#include <cstring>

extern "C" __declspec(dllexport) bool ValidateUserPassword(const std::wstring& username, const std::wstring& password) {
    HANDLE hToken = nullptr;
    std::wstring domain = L".";

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
        std::wcout << L"❌ فشل تسجيل الدخول، رمز الخطأ: " << error << std::endl;
        return false;
    }
}

namespace fs = std::filesystem;

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