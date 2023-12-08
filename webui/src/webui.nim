import happyx

when isMainModule:
  

  serve "127.0.0.1", 5001:  
    staticDir "views"
    staticDir "css"
    staticDir "fonts"
    staticDir "images"
    staticDir "js"

    get "/":
      return FileResponse("index.html")

    get "/home":
      return FileResponse("views/home.html")

    get "/login":
      return FileResponse("views/login.html")

    #get "/view2":
      #return FileResponse("views/view2.html")