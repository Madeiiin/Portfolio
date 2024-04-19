import React from 'react';
import {Button, Card, Container, Form, Row} from "react-bootstrap";
import {AUTH_ROUTE, REGISTRATION_ROUTE} from "../utils/consts";
import {NavLink, useLocation} from "react-router-dom";

const Auth = () => {
    const location = useLocation()
    const isLogin = location.pathname === AUTH_ROUTE
    console.log(location)

    return (
       <Container
           className="d-flex justify-content-center align-items-center"
           style={{height: window.innerHeight - 54}}
       >
        <Card style={{width: 600}} className="p-5">
            <h2 className="m-auto">{isLogin ? 'Login form' : 'Registration form'}</h2>
        <Form className="d-flex flex-column">
            <Form.Control
                className="mt-3"
                placeholder="Enter your email..."
            />
            <Form.Control
                className="mt-3"
                placeholder="Enter your password..."
            />
            <Row className="d-flex justify-content-between mt-3 ps-3 pe-3">
                {isLogin ?
                <div>
              New to NFT SHOP?<NavLink  className="ms-2" to={REGISTRATION_ROUTE}>Sign up.</NavLink>
                </div>
                    :
                    <div>
              Have an account?<NavLink  className="ms-2" to={AUTH_ROUTE}>Sign in.</NavLink>
                    </div>
                }
                <Button
                    className="mt-2"
                    variant={"outline-primary"}
                >
                    {isLogin ? 'Login' : 'Registration'}
                </Button>
            </Row>
        </Form>
        </Card>
       </Container>
    );
};

export default Auth;