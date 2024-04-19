import {
    ABOUT_ROUTE,
    ADMIN_ROUTE, ADVERT_ROUTE,
    AUTH_ROUTE, CONTACTS_ROUTE, INFO_ROUTE,
    NFT_ROUTE, PROFILE_ROUTE,
    REGISTRATION_ROUTE,
    SALES_ROUTE,
    SHOP_ROUTE
} from "./utils/consts";
import Shop from "./pages/Shop";
import Nft from "./pages/Nft";
import Auth from "./components/Auth";
import Registration from "./components/Registration";
import Admin from "./components/Admin";
import Sales from "./pages/Sales";
import About from "./pages/About";
import Contacts from "./pages/Contacts";
import Info from "./pages/Info";
import Profile from "./pages/Profile";
import Advert from "./pages/Content";
import Content from "./pages/Content";



export const publlcRoutes = [
    {
        path: SHOP_ROUTE,
        Component: Shop
    },
    {
        path: NFT_ROUTE + '/:id',
        Component: Nft
    },
    {
        path: AUTH_ROUTE,
        Component: Auth
    },
    {
        path: REGISTRATION_ROUTE,
        Component: Auth
    },
    {
        path: SALES_ROUTE,
        Component: Sales
    },
    {
        path: ABOUT_ROUTE,
        Component: About
    },
    {
        path: INFO_ROUTE,
        Component: Info
    },
    {
        path: CONTACTS_ROUTE,
        Component: Contacts
    },






]

export const authRoutes = [
    {
    path: ADMIN_ROUTE,
    Component: Admin
    },
    {
        path: PROFILE_ROUTE,
        Component: Profile
    },
]
