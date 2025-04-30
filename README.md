# FastUnzip

FastUnzip is a lightweight Windows tool that automatically extracts `.zip` files when you double-click them, just like macOS.

## Features
- Double-click any `.zip` ➔ Extracts automatically into a folder.
- No UI, silent operation.
- Lightweight single `.exe`.
- No dependency on installed .NET Framework (Self-contained).

## How to Install
1. Download the latest `FastUnzip-Installer.exe` from the [Releases](../../releases) section.
2. **Launch the installer**.
3. Done! Now double-clicking `.zip` files will extract them automatically.  
   *(If nothing happens, right-click a `.zip` ➔ "Open with" ➔ choose FastUnzip.)*

## How to Build
- Requires Visual Studio 2022 or later.
- Open the solution using the `.sln` and publish with `Self-contained` and `Single File` options.

## File Integrity (SHA256)

To verify the integrity of the installer, here is the SHA256 checksum:

```
06D374A6ADDE0DBD888838DA6C9FC865A1B046154B2312FCEABD361E2AE0CE26
```

To verify it using PowerShell:

```powershell
Get-FileHash -Algorithm SHA256 "FastUnzip-Installer.exe"
```

---

Made with ❤️ by Anomz

---

# 🇫🇷 FastUnzip

FastUnzip est un outil léger pour Windows qui extrait automatiquement les fichiers `.zip` lorsque vous double-cliquez dessus, comme sur macOS.

## Fonctionnalités
- Double-cliquez sur un fichier `.zip` ➔ Extraction automatique dans un dossier.
- Pas d'interface utilisateur, fonctionnement silencieux.
- Application légère en un seul `.exe`.
- Aucune dépendance au framework .NET installé (Autoporté).

## Comment installer
1. Téléchargez le fichier `FastUnzip-Installer.exe` depuis la section [Releases](../../releases).
2. **Lancer l'installateur"**.
3. C’est tout ! Un double-clic sur un fichier `.zip` l’extraira automatiquement.  
   *(Si cela ne fonctionne pas, faites un clic droit sur le `.zip` ➔ "Ouvrir avec" ➔ choisissez FastUnzip.)*

## Comment compiler
- Nécessite Visual Studio 2022 ou plus récent.
- Ouvrez la solution à l'aide du `.sln` et publiez avec les options **Automatique** et **Fichier unique**.

## Intégrité du fichier (SHA256)

Voici le hachage SHA256 de l’installateur, pour vérifier son intégrité :

```
06D374A6ADDE0DBD888838DA6C9FC865A1B046154B2312FCEABD361E2AE0CE26
```

Pour le vérifier via PowerShell :

```powershell
Get-FileHash -Algorithm SHA256 "FastUnzip-Installer.exe"
```

---

Fait avec ❤️ par Anomz
