The program checks whether a user meets certain criteria for access, based on the following rules:

1. The user is an **administrator** if their `userId` is **greater than 65536**.
2. The **username** must be at least **3 characters** long.
3. The **password** must:
    - Contain **at least one special character** from: `$`, `|`, `@`
    - Be at least:
        - **20 characters** long for an **admin**
        - **16 characters** long for a **non-admin**