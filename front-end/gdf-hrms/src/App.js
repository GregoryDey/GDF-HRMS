import ResponsiveDrawer from './Layout'
import Api from './Api'
import React from "react";

const App = () => {
  return (
    <div className="App">
     
       <ResponsiveDrawer>
         <h1>Hello There, thanks for stopping by. </h1>
         <Api />
       </ResponsiveDrawer>
    </div>
  );
}

export default App;
