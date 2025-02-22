const { app, BrowserWindow, Menu, dialog } = require("electron")

const createWindow = () => {
    const mainWindow = new BrowserWindow({
        width: 800,
        height: 600,
        minHeight: 200,
        minWidth: 400,
    })
    mainWindow.loadFile('src/index.html')
}

const menu = [{
    label: 'Tools',
    submenu: [{
        role: 'reload'
    }]
}]

const menu_template = Menu.buildFromTemplate(menu)

Menu.setApplicationMenu(menu_template)

app.whenReady().then(() => {
    createWindow()
})