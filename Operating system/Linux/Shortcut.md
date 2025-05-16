Below will be the content of a .desktop file.

If you see a gear icon or a file without an icon in your taskbar, make sure to match the `StartupWMClass` with the name of the opened window in your taskbar (If unsure press `Alt+F2` type `lg` select `Windows` and find the app process). (File will also need to be included in the `~/.local/share/applications` folder)

```
[Desktop Entry]
Version=1.0
Type=Application
Terminal=false
Exec= /* Path to exe*/
Name= /* Name of the app*/
Icon= /* Icon path*/
Comment= /* Description */
Categories= /* Categorize the app */
StartupWMClass= /* Process name */
```
