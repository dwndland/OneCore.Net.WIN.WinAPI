# Changelog

All notable changes to this project will be documented in this file.  
The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.1.0/),  
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

---
## [Unreleased]

## [1.0.1] - 2025-11-06
### Added
- Addd User32.GetCursorPos.

## [1.0.0] - 2025-11-05
### Added
- Initial public release of **OneCore.Net.WIN.WinAPI** — the Windows-specific utility library within the OneCore.Net ecosystem.
- Provides a safe and strongly-typed access layer for native Windows API functionality via P/Invoke.
- Includes helpers for window management, user interaction, process handling, and general Win32 interop scenarios.
- Designed to integrate seamlessly with other OneCore.Net components (WPF, Avalonia, and shared core libraries).
### Changed
- Formerly known as **OneCore.Net.WinAPI**.  
  The project has been renamed to clearly reflect its Windows-only purpose.
- Updated target framework to **.NET 8.0-windows** for explicit platform safety and modern runtime support.
### Notes
- This package fully replaces `OneCore.Net.WinAPI`.  
  The previous package has been deprecated on NuGet.org and will no longer receive updates.
- Requires Windows 10 or later.

## [1.0.0] - 2025-10-23
### Rebrand
- **Chapter.Net** has been rebranded and continued under the new name **OneCore.Net**.
- This library is part of the new **OneCore.Net** family and represents the direct continuation of the corresponding Chapter.Net package.
- The initial version (1.0.0) is functionally identical to the last Chapter.Net release.
- Future changes, improvements, and new features will be tracked here under the **OneCore.Net** name.

---

*Previous Chapter.Net changelog entries have been archived to mark a clean start for OneCore.Net.*
