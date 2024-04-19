import React, {createContext} from 'react';
import ReactDOM from 'react-dom';
import App from './App';
import UserStore from "./store/UserStore";
import NftStore from "./store/NftStore";
import {BrowserRouter as Router, Navigate, Outlet, Route, Routes} from "react-router-dom";
import Content from "./pages/Content";

export const Context = createContext(null)
const root = ReactDOM.createRoot(document.getElementById('root'))



root.render(

    <React.StrictMode>
    <Context.Provider value={{
            user: new UserStore(),
            nft: new NftStore(),
    }}>

        <App />
        <React.StrictMode>
            <Router>
                <Routes>
                    <Route name="Advert/" path="/Advert" element={<Outlet />}>
                        <Route index element={<Content page="1"/>} />
                    </Route>
                </Routes>
            </Router>
        </React.StrictMode>

    </Context.Provider>,
    </React.StrictMode>,


  document.getElementById('root')
);
