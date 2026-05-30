# Breez

Breez is a front-end Orchard Core theme built with Tailwind CSS v4 conventions and delivered as a prebuilt CSS bundle (no Node.js required in consuming projects).

## Prerequisites

- Orchard Core **2.2.1+**
- .NET **9** SDK/runtime

## Quick start

### Use as a NuGet package

1. Add the `Breez` package to your Orchard Core solution.
2. Enable the Breez theme in admin.
3. Run the `Breez` recipe from **Configuration → Recipes**.

### Use from source

```bash
git clone https://github.com/agriffard/Breez.git
cd Breez
dotnet build Breez.sln
```

Reference `src/Breez/Breez.csproj` from your Orchard Core host and enable the theme.

## Development

A prebuilt stylesheet is committed at `src/Breez/wwwroot/css/site.css`.

Optional: place the Tailwind standalone CLI binary (`tailwindcss` or `tailwindcss.exe`) in `src/Breez/` and build to regenerate CSS from `Assets/css/input.css`.

Watch mode example:

```bash
./tailwindcss -i Assets/css/input.css -o wwwroot/css/site.css --watch
```

## Design tokens and rebranding

Theme tokens are defined in `src/Breez/Assets/css/input.css` (`@theme` block):
- Brand color scale (`--color-brand-*`)
- Typography families (`--font-*`)
- Radius and shadow tokens

Update token values, then regenerate `wwwroot/css/site.css` with the standalone CLI.

## Recipe usage

`src/Breez/Recipes/Breez.recipe.json`:
- Enables and activates Breez
- Defines `Page`, `BlogPost`, and `Blog` content types
- Seeds sample EN/FR pages/posts
- Adds a main menu

This recipe is not a setup recipe and can be run on existing sites.

## Contributing

Contributions are welcome. Please keep changes focused, preserve accessibility, and maintain Orchard Core compatibility.

## License

MIT. See `src/Breez/LICENSE`.
