const { app, BrowserWindow } = require("electron")

const createWindow = () => {
    const mainWindow = new BrowserWindow({
        width: 800,
        height: 600,
        minHeight: 200,
        minWidth: 400,
    })
    mainWindow.loadFile('src/index.html')
}


app.whenReady().then(() => {
    createWindow()
})