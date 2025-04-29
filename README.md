# FastUnzip

FastUnzip is a lightweight Windows tool that automatically extracts `.zip` files when you double-click them, just like macOS.

## Features
- Double-click any `.zip` ➔ Extracts automatically into a folder.
- No UI, silent operation.
- Lightweight single `.exe` (~66Ko).
- No dependency on installed .NET Framework (Self-contained).

## How to Install
1. Download the latest `FastUnzip-Installer.exe` from Releases.
2. **Follow Instructions.**
3. Done! Now double-clicking `.zip` files will extract them automatically. Might need to select the app.

## How to Build
- Requires Visual Studio 2022 or later.
- Open the solution in `src/` and publish with `Self-contained` and `Single File` options.

## File Integrity (SHA256)

If you want to verify the integrity of the installer, here is the SHA256 checksum:

SHA256:B93AEFC4412095BF88E81B2ECB9DAF70656259E68402A105C4AD2C1DD42F455A 

To verify it, open PowerShell and run:

```powershell
Get-FileHash -Algorithm SHA256 "FastUnzip-Installer.exe"

---

Made with ❤️ by Anomz

---

# 🇫🇷 FastUnzip

FastUnzip est un outil léger pour Windows qui extrait automatiquement les fichiers `.zip` lorsque vous double-cliquez dessus, comme sur macOS.

## Fonctionnalités
- Double-cliquez sur un fichier `.zip` ➔ Extraction automatique dans un dossier.
- Pas d'interface utilisateur, fonctionnement silencieux.
- Application légère en un seul `.exe` (~66Ko).
- Aucune dépendance au framework .NET installé (Autoporté).

## Comment installer
1. Téléchargez l'installateur `FastUnzip-Installer.exe` depuis la section Releases.
2. **Suivre les instructions.**
3. C'est tout ! Maintenant, un double-clic sur un fichier `.zip` l'extraira automatiquement. Juste a sélectionner l'app pour extraire.

## Comment compiler
- Nécessite Visual Studio 2022 ou plus récent.
- Ouvrez la solution dans le dossier `src/` et publiez avec les options **Autoporté** et **Fichier unique**.

## File Integrity (SHA256)

If you want to verify the integrity of the installer, here is the SHA256 checksum:

SHA256:B93AEFC4412095BF88E81B2ECB9DAF70656259E68402A105C4AD2C1DD42F455A 

To verify it, open PowerShell and run:

```powershell
Get-FileHash -Algorithm SHA256 "FastUnzip-Installer.exe"

---

Fait avec ❤️ par Anomz
