import ResponsiveDrawer from './Layout'
import Api from './Api'
import React from "react";
import { BrowserRouter, Route } from 'react-router-dom';
import SearchPage from './searchpage';

const App = () => {
  return (
    <div className="App">
      <BrowserRouter>
        <ResponsiveDrawer>
          <h1>Hello There, thanks for stopping by. </h1>
          <Api />
          <Route path="/search-page" exact component={SearchPage} />
        </ResponsiveDrawer>
      </BrowserRouter>
    </div>
  );
}

export default App;
