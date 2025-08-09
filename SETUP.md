# Configuración del Entorno de Desarrollo - Signa Incantata

## 1. Instalar Unity Hub
1. Descargar desde: https://unity.com/download
2. Instalar Unity Hub

## 2. Instalar Unity LTS
1. Abrir Unity Hub
2. **Installs** → **Install Editor**
3. Seleccionar **Unity 2022.3 LTS**
4. Módulos requeridos:
   - ✅ Windows Build Support (IL2CPP)
   - ✅ Documentation

## 3. Configurar Visual Studio Code
### Extensiones recomendadas (se instalan automáticamente):
- **C#** - Soporte para C# y .NET
- **.NET Install Tool** - Runtime de .NET
- **Unity Debugger** - Debug para Unity
- **Unity Code Snippets** - Snippets de código Unity
- **Unity Tools** - Herramientas adicionales

### Configuración automática:
- Archivos Unity excluidos del explorador
- IntelliSense optimizado para Unity
- Configuración de OmniSharp

## 4. Crear Proyecto Unity
1. Abrir Unity Hub
2. **Projects** → **New project**
3. Template: **3D Core**
4. Nombre: **Signa_Incantata**
5. Ubicación: Esta carpeta
6. **Create project**

## 5. Configurar Unity para VS Code
1. En Unity: **Edit** → **Preferences**
2. **External Tools** → **External Script Editor**
3. Seleccionar **Visual Studio Code**
4. Aplicar cambios

## 6. Verificar instalación
- Crear script de prueba en Unity
- Abrir en VS Code
- Verificar IntelliSense y autocompletado