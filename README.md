# Colheita da Noite (Unity)

Protótipo base do jogo na Unity com ciclo dia/noite, corrupção e início narrativo.

## Status real do checklist (não concluído 100%)

> Correção: os itens da história **não estão todos finalizados**. Abaixo está o recorte de produção para vertical slice.

### ✅ Concluído agora
- [x] Base técnica inicial em Unity (`GameState`, `DayNightCycle`, `CorruptionSystem`, `IntroSequence`)
- [x] Primeira noite com gatilho narrativo
- [x] Estrutura de scripts por domínio (Core / Systems / Narrative)
- [x] Pipeline para registrar assets do projeto (`AssetManifest` + validador)

### 🟡 Em progresso
- [ ] Cena chegando ao vale
- [ ] Primeira visão da fazenda
- [ ] Primeiros NPCs interativos
- [ ] Primeira criatura com comportamento
- [ ] Tutorial jogável de sobrevivência

### 🔴 Pendente (macro)
- [ ] História completa da mina por documentos in-game
- [ ] Sistema completo de escolhas e consequências
- [ ] Implementação dos 4 finais
- [ ] Cinemáticas principais

---

## Scripts existentes

- `Assets/Scripts/Core/GameState.cs`
- `Assets/Scripts/Core/AssetManifest.cs`
- `Assets/Scripts/Systems/DayNightCycle.cs`
- `Assets/Scripts/Systems/CorruptionSystem.cs`
- `Assets/Scripts/Systems/AssetBootstrapper.cs`
- `Assets/Scripts/Narrative/IntroSequence.cs`

---

## Implementação de assets do diretório do projeto

Para conectar assets ao game loop:

1. Crie um `AssetManifest` em `Create > ColheitaDaNoite > Asset Manifest`.
2. Preencha listas com seus assets (prefabs, áudio, materiais e VFX).
3. Adicione `AssetBootstrapper` em uma cena inicial e arraste o `AssetManifest`.
4. Execute a cena: o bootstrap valida ausências e registra logs de integridade.

> Observação: neste repositório atual não vieram arquivos de arte/áudio versionados além dos scripts. O pipeline foi preparado para receber esses assets assim que forem adicionados.

---

## Próximo passo recomendado

1. Importar seus assets reais para `Assets/GameArt`, `Assets/Audio`, `Assets/Prefabs`.
2. Popular o `AssetManifest`.
3. Criar cena `Farm_Day` e validar:
   - Ciclo de tempo
   - Crescimento de corrupção
   - Disparo da primeira noite
   - Instanciação de 1 prefab via evento narrativo
