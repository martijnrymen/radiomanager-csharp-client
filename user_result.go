/* 
 * Pluxbox Radiomanager Client
 *
 * Pluxbox RadioManager gives you the power, flexibility and speed you always wanted in a lightweight and easy-to-use web-based radio solution. With Pluxbox RadioManager you can organise your radio workflow and automate your omnichannel communication with your listeners. We offer wide range specialised services for the radio and connections like Hybrid Radio, Visual Radio, your website and social media without losing focus on your broadcast. For more information visit https://pluxbox.com
 *
 * OpenAPI spec version: 2.0
 * Contact: support@pluxbox.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

package radiomanagerclient

import (
	"time"
)

type UserResult struct {

	Id int64 `json:"id"`

	Email string `json:"email"`

	Firstname string `json:"firstname"`

	Lastname string `json:"lastname"`

	Phone string `json:"phone,omitempty"`

	CreatedAt time.Time `json:"created_at,omitempty"`

	UpdatedAt time.Time `json:"updated_at,omitempty"`

	Active bool `json:"active,omitempty"`

	Settings UserResultSettings `json:"settings,omitempty"`

	Language bool `json:"language,omitempty"`

	ActiveExternalStationId int64 `json:"active_external_station_id,omitempty"`

	RoleId int64 `json:"role_id,omitempty"`
}