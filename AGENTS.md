# AGENTS.md

GMIUI: a MIUI 11 custom ROM download site (Turkish) and a Windows fastboot installer for General Mobile GM8 owners.

## Verify a change

- The only workflow is `.github/workflows/static.yml`: on push to `main` it uploads `web/` as-is to GitHub Pages. There is no build and no test job.
- Run `npm ci && npx prettier --check .` before pushing. The repo is Prettier-formatted, `npm run format` rewrites files in place.
- For site changes, open `web/index.html` in a browser. Paths are relative (`./assets/...`) so the page works under the `/general-mobile-gm8-miui/` Pages base path.
- The installer (`src/GM8 MIUI.sln`) is .NET Framework 4.7.2 WinForms and builds only on Windows with Visual Studio or MSBuild after a NuGet restore.

## Gotchas

- Only `web/` is deployed. `robots.txt`, `sitemap.xml`, `llms.txt` and `og.png` live there, and absolute URLs in them use `https://halitsever.github.io/general-mobile-gm8-miui/`.
- `web/og.png` is a copy of `.github/social-preview.png`. Update both together. The owner uploads the social preview in repo settings by hand.
- `web/.gitattributes` hides HTML and CSS from Linguist so GitHub reports the repo as C#.
- The site is in Turkish (`lang="tr"`), the README in English. Keep each in its language.
- `Form1.cs` runs each `fastboot.exe` command in its own console window and waits for it to exit before starting the next. It has not been compiled or run against a device since that change, so treat the installer as untested.
- Dependabot bumps `packages.config` (MaterialSkin.2 is at 2.3.1) but the csproj `HintPath` still points at `MaterialSkin.2.2.2.1`. Fix both when touching NuGet references.
- `package.json` only exists for Prettier. It is not published. Its `license` says ISC while `LICENSE` is MIT, and its `description` is pasted HTML.
- ROM images are not in the repo. Downloads are external bit.ly / Google Drive links in `web/index.html`. Old `gm8miui.glitch.me` links are dead (HTTP 410).
- The history is about 100 MB. Clone with `--depth 1 --filter=blob:limit=5m`.

## Conventions

- Commit subjects in conventional-commit style, English, subject line only, no body or trailer.
- Work on a branch and open a PR. The owner merges.
- No emoji in new text. Code comments are short, one line where possible, and explain why.
- The README follows the owner's template. Every image from `halitsever-api.vercel.app` stays byte-for-byte, except the `title=` value of `api/repo-title` and the issue wrapper link.
- Version bumps and releases are done by the owner.
