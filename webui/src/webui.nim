import happyx

when isMainModule:
  

  serve "127.0.0.1", 5001:  
  
    staticDir "css"
    staticDir "fonts"
    staticDir "images"
    staticDir "js"

    get "/":
      return FileResponse("index.html")