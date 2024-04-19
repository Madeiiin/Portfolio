import React from 'react';
import {Card, Col, Container, FormLabel} from "react-bootstrap";

const Profile = () => {
const user =  {id: 1, username: "Rigaev", email:"cosodfq@mail.ru"};
    return (
        <Container className={"mt-5"}>
            <Col md={4}>
            <Card>
                <FormLabel>Username: {user.username}</FormLabel>
                <FormLabel>Email: {user.email}</FormLabel>

            </Card>
            </Col>
        </Container>
    );
};

export default Profile;